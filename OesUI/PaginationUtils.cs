using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using OesUI.Custom;

namespace OesUI
{
    public delegate void CustomPaginationQuery();

    //pagination class
    public class PaginationUtils
    {
        private const string perPage = "Per Page";
        private string dotStr = "...";
        private string goTextBox = "tbPageNum";
        private string pageChooseCB = "cmbPageSize";
        private Font formalFont = new Font(Constants.Arial, 9);
        private Color formalColor = Color.FromArgb(94, 94, 94);
        private Color currentPageColor = Color.FromArgb(254, 153, 1);
        private Color color = Color.FromArgb(94, 94, 94);

        private FlowLayoutPanel panel;
        private CustomTipDialog customTipDialog;
        private string hintFirst;
        private string hintLast;
        private int[] pageSizeCollection;
        private string tipPageInput;
        private CustomPaginationQuery custQuery;
        private int preBtnWidth = 20;
        private int preBtnHeight = 15;
        private int pageWidth = 20;
        private int pageHeight = 20;
        private string goStr = "lblGo";
        private string goText = "Go";
        private int goBtnWidth = 30;
        private int goBtnHeight = 15;
        private int goTextWidth = 35;
        private int goTextHeight = 15;
        private int textMaxLength = 5;
        private int comboxWidth = 50;
        private int comboxHeight = 15;
        private int _currentPage = 1;
        private int _pageSize = 10;
        private int paddingTop = 6;

        public int TotalRecord { get; set; }
        public int PageSize 
        {
            get 
            {
                return _pageSize; 
            }

            set
            {
                _pageSize = value;
            }
        }

        public int CurrentPage
        {
            get
            {
                return _currentPage;
            }

            set
            {
                this._currentPage = value;
            }
        }

        public int TotalPage 
        {
            get
            {
                if (TotalRecord == 0)
                {
                    return 0;
                }
                else if (TotalRecord % this._pageSize == 0)
                {
                    return TotalRecord / this._pageSize;
                }
                else if (TotalRecord % this._pageSize != 0)
                {
                    return TotalRecord / this._pageSize + 1;
                }
                return 0;
            }
        }

        public PaginationUtils(FlowLayoutPanel panel, CustomTipDialog customTipDialog,
            string hintFirst, string hintLast, string tipPageInput, int[] pageSizeCollection,
            CustomPaginationQuery custQuery)
        {
            this.panel = panel;
            this.customTipDialog = customTipDialog;
            this.hintFirst = hintFirst;
            this.hintLast = hintLast;
            this.tipPageInput = tipPageInput;
            this.pageSizeCollection = pageSizeCollection;
            this.custQuery = custQuery;
        }

        #region
        private Label PreOrNextCommon(Image bgImage)
        {
            Label preOrNextlbl = new Label();
            preOrNextlbl.AutoSize = false;
            preOrNextlbl.Margin = new Padding(0, paddingTop, 5, 0);
            preOrNextlbl.Width = preBtnWidth;
            preOrNextlbl.Height = preBtnHeight;
            preOrNextlbl.Cursor = Cursors.Hand;
            preOrNextlbl.Image = bgImage;
            return preOrNextlbl;
        }

        private void CreatePreBtn(Image bgImage)
        {
            Label preBtn = PreOrNextCommon(bgImage);
            preBtn.Click += new EventHandler(Prep_Click);
            panel.Controls.Add(preBtn);
        }

        private void CreateNextBtn(Image bgImage)
        {
            Label nextBtn = PreOrNextCommon(bgImage);
            nextBtn.Click += new EventHandler(Next_Click);
            panel.Controls.Add(nextBtn);
        }

        private void CreatePage(int text, Font font, Color color)
        {
            Label page = new Label();
            page.AutoSize = true;
            page.Width = pageWidth;
            page.Height = pageHeight;
            page.Text = text.ToString();
            page.Font = font;
            page.Padding = new Padding(0, paddingTop, 0, 0);
            page.ForeColor = color;
            page.Cursor = Cursors.Hand;
            page.Click += new EventHandler(Page_Click);
            panel.Controls.Add(page);
        }

        private void CreateDotPage(string text)
        {
            Label dot = new Label();
            dot.Font = formalFont;
            dot.Padding = new Padding(0, paddingTop, 0, 0);
            dot.TextAlign = ContentAlignment.MiddleCenter;
            dot.ForeColor = Color.FromArgb(94, 94, 94);
            dot.AutoSize = true;
            dot.Width = pageWidth;
            dot.Height = pageHeight;
            dot.Text = text;
            panel.Controls.Add(dot);
        }

        private void CreateGoBtn(TextBox textbox)
        {
            Label go = new Label();
            go.AutoSize = true;
            go.Margin = new Padding(0, paddingTop, 0, 0);
            go.Width = goBtnWidth;
            go.Height = goBtnHeight;
            go.Name = goStr;
            go.Text = goText;
            go.Tag = textbox;
            go.TextAlign = ContentAlignment.MiddleCenter;
            go.Font = formalFont;
            go.ForeColor = Color.White;
            go.BackColor = currentPageColor;
            go.Cursor = Cursors.Hand;
            go.Margin = new Padding(0, 5, 0, 0);
            go.Click += new EventHandler(lblGo_Click);
            panel.Controls.Add(go);
        }

        private TextBox CreateGoPageText()
        {
            TextBox textBox = new TextBox();
            textBox.Name = goTextBox;
            textBox.Width = goTextWidth;
            textBox.Height = goTextHeight;
            textBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textBox.MaxLength = textMaxLength;
            textBox.ForeColor = currentPageColor;
            textBox.BackColor = Color.White;
            textBox.Font = formalFont;
            panel.Controls.Add(textBox);
            return textBox;
        }

        private void CreatePageSizeChoose()
        {
            ComboBox combox = new ComboBox();
            combox.Name = pageChooseCB;
            combox.Width = comboxWidth;
            combox.Height = comboxHeight;
            combox.Font = formalFont;
            combox.DropDownStyle = ComboBoxStyle.DropDownList;
            combox.Cursor = Cursors.Hand;
            combox.BackColor = Color.White;
            combox.ForeColor = currentPageColor;
            combox.DataSource = pageSizeCollection;
            panel.Controls.Add(combox);

            combox.SelectedIndex = PageSize / 5 - 1;
            combox.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
        }

        public void CustPagination(int curPage, int pageCount)
        {
            //clear last pagination
            panel.Controls.Clear();

            Image preImage = OesUI.Properties.Resources.BTN_PageLeft_20x15_png;
            CreatePreBtn(preImage);

            if (pageCount < 5)
            {
                for (int i = 0; i < pageCount; i++)
                {
                    if ((i + 1) == curPage)
                    {
                        color = currentPageColor;
                    }
                    CreatePage(i + 1, formalFont, color);
                    color = formalColor;
                }
            }
            else
            {
                if (curPage - 3 > 1)
                {
                    CreatePage(1, formalFont, color);
                    CreateDotPage(dotStr);

                    for (var i = curPage - 2; i <= curPage; i++)
                    {
                        if (i == curPage)
                        {
                            color = currentPageColor;
                        }
                        CreatePage(i, formalFont, color);
                        color = formalColor;
                    }
                }
                else
                {
                    for (var i = 1; i <= curPage; i++)
                    {
                        if (i == curPage)
                        {
                            color = currentPageColor;
                        }
                        CreatePage(i, formalFont, color);
                        color = formalColor;
                    }
                }

                if (curPage + 3 < pageCount)
                {
                    for (var i = curPage + 1; i <= curPage + 2; i++)
                    {
                        CreatePage(i, formalFont, color);
                    }

                    CreateDotPage(dotStr);
                    CreatePage(pageCount, formalFont, color);
                }
                else
                {
                    for (var i = curPage + 1; i <= pageCount; i++)
                    {
                        CreatePage(i, formalFont, color);
                    }
                }
            }

            Image nextImage = OesUI.Properties.Resources.BTN_PageRight_20x15_png;
            CreateNextBtn(nextImage);
            CreatePageSizeChoose();
            CreateDotPage(perPage);

            TextBox textbox = CreateGoPageText();
            CreateGoBtn(textbox);
        }
        #endregion

        private void Prep_Click(object sender, EventArgs e)
        {
            if (CurrentPage == 1)
            {
                customTipDialog.TipMessage = hintFirst;
                customTipDialog.Show();
                return;
            }
            else
            {
                CurrentPage -= 1;
                custQuery();
                CustPagination(CurrentPage, TotalPage);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (CurrentPage == TotalPage)
            {
                customTipDialog.TipMessage = hintLast;
                customTipDialog.Show();
                return;
            }
            else
            {
                CurrentPage += 1;
                custQuery();
                CustPagination(CurrentPage, TotalPage);
            }
        }

        private void Page_Click(object sender, EventArgs e)
        {
            CurrentPage = int.Parse(((Label)sender).Text);
            custQuery();
            CustPagination(CurrentPage, TotalPage);
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CbPageSize = int.Parse(((ComboBox)sender).Text);
            PageSize = CbPageSize;
            CurrentPage = 1;

            custQuery();
            CustPagination(CurrentPage, TotalPage);
        }

        private void lblGo_Click(object sender, EventArgs e)
        {
            GoPageOperation((TextBox)(((Label)sender).Tag));
        }

        private void GoPageOperation(TextBox textBox)
        {
            if (textBox.Text.Equals(string.Empty))
            {
                customTipDialog.TipMessage = tipPageInput;
                customTipDialog.Show();
                return;
            }

            int goPageNum = 1;
            try
            {
                goPageNum = int.Parse(textBox.Text);
                textBox.Text = string.Empty;
                if (goPageNum <= 0)
                {
                    goPageNum = 1;
                }
                else if (goPageNum > TotalPage)
                {
                    goPageNum = TotalPage;
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

            CurrentPage = goPageNum;
            custQuery();
            CustPagination(CurrentPage, TotalPage);
        }
    }
}
