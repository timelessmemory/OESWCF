using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace OesUI.Custom
{
    class FunctionButton : Control
    {
        public Font TextFont { get; set; }
        public Color DefaultFontColor { get; set; }
        public Color SelectedFontColor { get; set; }
        public Image DefaultImage { get; set; }
        public Image SelectedImage { get; set; }
        private Color _currentColor;
        private Image _currentImage;
        private bool _isSelected;

        public bool IsSelected 
        {
            get 
            {
                return _isSelected;
            }
            set 
            {
                _isSelected = value;

                if (_isSelected)
                {
                    _currentColor = SelectedFontColor;
                    _currentImage = SelectedImage;
                }
                else
                {
                    _currentImage = DefaultImage;
                    _currentColor = DefaultFontColor;
                }
            } 
        }

        public FunctionButton()
        {
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.UpdateStyles();
            base.CreateControl();

            this.Width = 150;
            this.Height = 50;
            this._currentImage = new Bitmap(24, 24);
            this._currentColor = Color.Blue;
            this.TextFont = new Font("Microsoft Yahei", 15);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //0x20 transparent
                return cp;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!this.IsSelected)
            {
                IsSelected = true;
                this.Invalidate();

                foreach (Control item in this.Parent.Controls)
                {
                    if (item is FunctionButton && item != this)
                    {
                        if ((item as FunctionButton).IsSelected)
                        {
                            (item as FunctionButton).IsSelected = false;
                            item.Invalidate();
                        }
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(_currentImage, new Point(15, 13));
            e.Graphics.DrawString(this.Text, this.TextFont, new SolidBrush(_currentColor), new Point(45, 18));
        }
    }
}
