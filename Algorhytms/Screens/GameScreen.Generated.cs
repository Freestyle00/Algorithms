#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
#define SUPPORTS_GLUEVIEW_2
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace Algorhytms.Screens
{
    public abstract partial class GameScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static Algorhytms.GumRuntimes.GameScreenGumRuntime GameScreenGum;
        
        protected FlatRedBall.TileGraphics.LayeredTileMap Map;
        protected FlatRedBall.TileCollisions.TileShapeCollection SolidCollision;
        protected FlatRedBall.TileCollisions.TileShapeCollection CloudCollision;
        private Algorhytms.Entities.Player PlayerInstance;
        private Algorhytms.Entities.Goalpost GoalpostInstance;
        private FlatRedBall.Math.Collision.CollidableVsTileShapeCollectionRelationship<Algorhytms.Entities.Player> PlayerInstanceVsSolidCollision;
        Algorhytms.FormsControls.Screens.GameScreenGumForms Forms;
        Algorhytms.GumRuntimes.GameScreenGumRuntime GumScreen;
        public GameScreen () 
        	: base ("GameScreen")
        {
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection CloudCollision in Screens\GameScreen (Screen) because properties on the object prevent it
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection SolidCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            // Not instantiating for FlatRedBall.TileCollisions.TileShapeCollection CloudCollision in Screens\GameScreen (Screen) because properties on the object prevent it
            PlayerInstance = new Algorhytms.Entities.Player(ContentManagerName, false);
            PlayerInstance.Name = "PlayerInstance";
            PlayerInstance.CreationSource = "Glue";
            GoalpostInstance = new Algorhytms.Entities.Goalpost(ContentManagerName, false);
            GoalpostInstance.Name = "GoalpostInstance";
            GoalpostInstance.CreationSource = "Glue";
                if (SolidCollision != null)
    {
        PlayerInstanceVsSolidCollision = FlatRedBall.Math.Collision.CollisionManagerTileShapeCollectionExtensions.CreateTileRelationship(FlatRedBall.Math.Collision.CollisionManager.Self, PlayerInstance, SolidCollision);
        PlayerInstanceVsSolidCollision.Name = "PlayerInstanceVsSolidCollision";
        PlayerInstanceVsSolidCollision.SetMoveCollision(0f, 1f);
    }

            GumScreen = GameScreenGum;
            Forms = new Algorhytms.FormsControls.Screens.GameScreenGumForms(GameScreenGum);
            FillCollisionForSolidCollision();
            FillCollisionForCloudCollision();
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            GameScreenGum.AddToManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            PlayerInstance.AddToManagers(mLayer);
            GoalpostInstance.AddToManagers(mLayer);
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(Map);
            base.AddToManagers();
            AddToManagersBottomUp();
            BeforeCustomInitialize?.Invoke();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                PlayerInstance.Activity();
                GoalpostInstance.Activity();
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void ActivityEditMode () 
        {
            if (FlatRedBall.Screens.ScreenManager.IsInEditMode)
            {
                PlayerInstance.ActivityEditMode();
                GoalpostInstance.ActivityEditMode();
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            GameScreenGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            GameScreenGum = null;
            
            if (PlayerInstance != null)
            {
                PlayerInstance.Destroy();
                PlayerInstance.Detach();
            }
            if (GoalpostInstance != null)
            {
                GoalpostInstance.Destroy();
                GoalpostInstance.Detach();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (Map!= null)
            {
            }
            if (SolidCollision!= null)
            {
            }
            if (CloudCollision!= null)
            {
            }
            if (PlayerInstance.Parent == null)
            {
                PlayerInstance.X = 24f;
            }
            else
            {
                PlayerInstance.RelativeX = 24f;
            }
            if (PlayerInstance.Parent == null)
            {
                PlayerInstance.Y = -488f;
            }
            else
            {
                PlayerInstance.RelativeY = -488f;
            }
            if (GoalpostInstance.Parent == null)
            {
                GoalpostInstance.X = 488f;
            }
            else
            {
                GoalpostInstance.RelativeX = 488f;
            }
            if (GoalpostInstance.Parent == null)
            {
                GoalpostInstance.Y = -24f;
            }
            else
            {
                GoalpostInstance.RelativeY = -24f;
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            GameScreenGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            PlayerInstance.RemoveFromManagers();
            GoalpostInstance.RemoveFromManagers();
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
                PlayerInstance.AssignCustomVariables(true);
                GoalpostInstance.AssignCustomVariables(true);
            }
            if (Map != null)
            {
            }
            if (SolidCollision != null)
            {
            }
            if (CloudCollision != null)
            {
            }
            if (PlayerInstance.Parent == null)
            {
                PlayerInstance.X = 24f;
            }
            else
            {
                PlayerInstance.RelativeX = 24f;
            }
            if (PlayerInstance.Parent == null)
            {
                PlayerInstance.Y = -488f;
            }
            else
            {
                PlayerInstance.RelativeY = -488f;
            }
            if (GoalpostInstance.Parent == null)
            {
                GoalpostInstance.X = 488f;
            }
            else
            {
                GoalpostInstance.RelativeX = 488f;
            }
            if (GoalpostInstance.Parent == null)
            {
                GoalpostInstance.Y = -24f;
            }
            else
            {
                GoalpostInstance.RelativeY = -24f;
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            if (Map != null)
            {
            }
            if (SolidCollision != null)
            {
            }
            if (CloudCollision != null)
            {
            }
            PlayerInstance.ConvertToManuallyUpdated();
            GoalpostInstance.ConvertToManuallyUpdated();
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            if(GameScreenGum == null) GameScreenGum = (Algorhytms.GumRuntimes.GameScreenGumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetScreen("GameScreenGum"), true);
            Algorhytms.Entities.Player.LoadStaticContent(contentManagerName);
            Algorhytms.Entities.Goalpost.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        [System.Obsolete("Use GetFile instead")]
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        private void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            GameScreenGum.UpdateLayout();
        }
        protected virtual void FillCollisionForSolidCollision () 
        {
            if (SolidCollision != null)
            {
                // normally we wait to set variables until after the object is created, but in this case if the
                // TileShapeCollection doesn't have its Visible set before creating the tiles, it can result in
                // really bad performance issues, as shapes will be made visible, then invisible. Really bad perf!
                SolidCollision.Visible = false;
                FlatRedBall.TileCollisions.TileShapeCollectionLayeredTileMapExtensions.AddCollisionFromTilesWithType(SolidCollision, Map, "SolidCollision", false);
            }
        }
        protected virtual void FillCollisionForCloudCollision () 
        {
            if (CloudCollision != null)
            {
                // normally we wait to set variables until after the object is created, but in this case if the
                // TileShapeCollection doesn't have its Visible set before creating the tiles, it can result in
                // really bad performance issues, as shapes will be made visible, then invisible. Really bad perf!
                CloudCollision.Visible = false;
                FlatRedBall.TileCollisions.TileShapeCollectionLayeredTileMapExtensions.AddCollisionFromTilesWithType(CloudCollision, Map, "CloudCollision", false);
            }
        }
        partial void CustomActivityEditMode();
    }
}
