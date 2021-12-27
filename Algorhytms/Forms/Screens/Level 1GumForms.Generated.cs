    namespace Algorhytms.FormsControls.Screens
    {
        public partial class Level 1GumForms
        {
            private Gum.Wireframe.GraphicalUiElement Visual;
            public Level 1GumForms () 
            {
                CustomInitialize();
            }
            public Level 1GumForms (Gum.Wireframe.GraphicalUiElement visual) 
            {
                Visual = visual;
                ReactToVisualChanged();
                CustomInitialize();
            }
            private void ReactToVisualChanged () 
            {
            }
            partial void CustomInitialize();
        }
    }
