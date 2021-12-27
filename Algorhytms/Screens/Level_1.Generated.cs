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
    public partial class Level_1 : GameScreen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static FlatRedBall.TileGraphics.LayeredTileMap LayeredTileMapFile;
        
        private FlatRedBall.TileGraphics.LayeredTileMap LayeredTileMapInstance;
        public Level_1 () 
        	: base ()
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = new FlatRedBall.TileGraphics.LayeredTileMap();
            Map.Name = "Map";
            SolidCollision = new FlatRedBall.TileCollisions.TileShapeCollection(); SolidCollision.Name = "SolidCollision";
            CloudCollision = new FlatRedBall.TileCollisions.TileShapeCollection(); CloudCollision.Name = "CloudCollision";
            LayeredTileMapInstance = new FlatRedBall.TileGraphics.LayeredTileMap();
            LayeredTileMapInstance.Name = "LayeredTileMapInstance";
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            LayeredTileMapFile.AddToManagers(mLayer);
            Map.AddToManagers();
            LayeredTileMapInstance.AddToManagers();
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                LayeredTileMapFile?.AnimateSelf();;
                Map?.AnimateSelf();;
                LayeredTileMapInstance?.AnimateSelf();;
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
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            LayeredTileMapFile.Destroy();
            LayeredTileMapFile = null;
            
            if (Map != null)
            {
                Map.Destroy();
            }
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
            if (CloudCollision != null)
            {
                CloudCollision.Visible = false;
            }
            if (LayeredTileMapInstance != null)
            {
                LayeredTileMapInstance.Destroy();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            LayeredTileMapFile.Destroy();
            if (Map != null)
            {
                Map.Destroy();
            }
            if (SolidCollision != null)
            {
                SolidCollision.Visible = false;
            }
            if (CloudCollision != null)
            {
                CloudCollision.Visible = false;
            }
            if (LayeredTileMapInstance != null)
            {
                LayeredTileMapInstance.Destroy();
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
            }
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            Algorhytms.Screens.GameScreen.LoadStaticContent(contentManagerName);
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
            LayeredTileMapFile = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/level_1/layeredtilemapfile.tmx", contentManagerName);
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
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "LayeredTileMapFile":
                    return LayeredTileMapFile;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "LayeredTileMapFile":
                    return LayeredTileMapFile;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "LayeredTileMapFile":
                    return LayeredTileMapFile;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        partial void CustomActivityEditMode();
    }
}
