    namespace FlatRedBall.Gum
    {
        public  class GumIdbExtensions
        {
            public static void RegisterTypes () 
            {
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Circle", typeof(Algorhytms.GumRuntimes.CircleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("ColoredRectangle", typeof(Algorhytms.GumRuntimes.ColoredRectangleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container", typeof(Algorhytms.GumRuntimes.ContainerRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Container<T>", typeof(Algorhytms.GumRuntimes.ContainerRuntime<>));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("NineSlice", typeof(Algorhytms.GumRuntimes.NineSliceRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Polygon", typeof(Algorhytms.GumRuntimes.PolygonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Rectangle", typeof(Algorhytms.GumRuntimes.RectangleRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Sprite", typeof(Algorhytms.GumRuntimes.SpriteRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("Text", typeof(Algorhytms.GumRuntimes.TextRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Button", typeof(Algorhytms.GumRuntimes.DefaultForms.ButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/CheckBox", typeof(Algorhytms.GumRuntimes.DefaultForms.CheckBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ColoredFrame", typeof(Algorhytms.GumRuntimes.DefaultForms.ColoredFrameRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ComboBox", typeof(Algorhytms.GumRuntimes.DefaultForms.ComboBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/DialogBox", typeof(Algorhytms.GumRuntimes.DefaultForms.DialogBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Keyboard", typeof(Algorhytms.GumRuntimes.DefaultForms.KeyboardRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/KeyboardKey", typeof(Algorhytms.GumRuntimes.DefaultForms.KeyboardKeyRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Label", typeof(Algorhytms.GumRuntimes.DefaultForms.LabelRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ListBox", typeof(Algorhytms.GumRuntimes.DefaultForms.ListBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ListBoxItem", typeof(Algorhytms.GumRuntimes.DefaultForms.ListBoxItemRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/PasswordBox", typeof(Algorhytms.GumRuntimes.DefaultForms.PasswordBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/RadioButton", typeof(Algorhytms.GumRuntimes.DefaultForms.RadioButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollBar", typeof(Algorhytms.GumRuntimes.DefaultForms.ScrollBarRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollBarThumb", typeof(Algorhytms.GumRuntimes.DefaultForms.ScrollBarThumbRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ScrollViewer", typeof(Algorhytms.GumRuntimes.DefaultForms.ScrollViewerRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Slider", typeof(Algorhytms.GumRuntimes.DefaultForms.SliderRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TextBox", typeof(Algorhytms.GumRuntimes.DefaultForms.TextBoxRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/Toast", typeof(Algorhytms.GumRuntimes.DefaultForms.ToastRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/ToggleButton", typeof(Algorhytms.GumRuntimes.DefaultForms.ToggleButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeView", typeof(Algorhytms.GumRuntimes.DefaultForms.TreeViewRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeViewItem", typeof(Algorhytms.GumRuntimes.DefaultForms.TreeViewItemRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/TreeViewToggleButton", typeof(Algorhytms.GumRuntimes.DefaultForms.TreeViewToggleButtonRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("DefaultForms/UserControl", typeof(Algorhytms.GumRuntimes.DefaultForms.UserControlRuntime));
                GumRuntime.ElementSaveExtensions.RegisterGueInstantiationType("GameScreenGum", typeof(Algorhytms.GumRuntimes.GameScreenGumRuntime));
                
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Button)] = typeof(Algorhytms.GumRuntimes.DefaultForms.ButtonRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.CheckBox)] = typeof(Algorhytms.GumRuntimes.DefaultForms.CheckBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ComboBox)] = typeof(Algorhytms.GumRuntimes.DefaultForms.ComboBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.DialogBox)] = typeof(Algorhytms.GumRuntimes.DefaultForms.DialogBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Games.OnScreenKeyboard)] = typeof(Algorhytms.GumRuntimes.DefaultForms.KeyboardRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Label)] = typeof(Algorhytms.GumRuntimes.DefaultForms.LabelRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ListBox)] = typeof(Algorhytms.GumRuntimes.DefaultForms.ListBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ListBoxItem)] = typeof(Algorhytms.GumRuntimes.DefaultForms.ListBoxItemRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.PasswordBox)] = typeof(Algorhytms.GumRuntimes.DefaultForms.PasswordBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.RadioButton)] = typeof(Algorhytms.GumRuntimes.DefaultForms.RadioButtonRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ScrollBar)] = typeof(Algorhytms.GumRuntimes.DefaultForms.ScrollBarRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ScrollViewer)] = typeof(Algorhytms.GumRuntimes.DefaultForms.ScrollViewerRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Slider)] = typeof(Algorhytms.GumRuntimes.DefaultForms.SliderRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TextBox)] = typeof(Algorhytms.GumRuntimes.DefaultForms.TextBoxRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.Popups.Toast)] = typeof(Algorhytms.GumRuntimes.DefaultForms.ToastRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.ToggleButton)] = typeof(Algorhytms.GumRuntimes.DefaultForms.ToggleButtonRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TreeView)] = typeof(Algorhytms.GumRuntimes.DefaultForms.TreeViewRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.TreeViewItem)] = typeof(Algorhytms.GumRuntimes.DefaultForms.TreeViewItemRuntime);
                FlatRedBall.Forms.Controls.FrameworkElement.DefaultFormsComponents[typeof(FlatRedBall.Forms.Controls.UserControl)] = typeof(Algorhytms.GumRuntimes.DefaultForms.UserControlRuntime);
            }
        }
    }
