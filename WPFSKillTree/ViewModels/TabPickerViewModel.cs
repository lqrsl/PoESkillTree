﻿using System.Windows.Media;

namespace POESKillTree.ViewModels
{
    public enum TabPickerResult
    {
        Affirmative,
        Negative,
        Delete
    }

    public class TabPickerViewModel : CloseableViewModel<TabPickerResult>
    {
        private bool _isDeletable = true;
        public bool IsDeletable
        {
            get { return _isDeletable; }
            set { SetProperty(ref _isDeletable, value); }
        }

        private string _name = "";
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private Color _color = Color.FromRgb(98, 128, 0);
        public Color Color
        {
            get { return _color; }
            set { SetProperty(ref _color, value); }
        }
    }
}