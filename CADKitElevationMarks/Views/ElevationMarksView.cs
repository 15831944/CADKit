﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CADKit.Views.WF;
using CADKitElevationMarks.Contracts.Views;
using CADKitElevationMarks.Contracts.Presenters;
using CADKit.Models;
using CADKitElevationMarks.DTO;

namespace CADKitElevationMarks.Views
{  
    public partial class ElevationMarksView : BaseViewWF, IElevationMarksView
    {
        public IElevationMarksPresenter Presenter { get; set; }

        public ElevationMarksView()
        {
            InitializeComponent();
        }

        public override void RegisterHandlers()
        {
            base.RegisterHandlers();
        }

        private class StandardTabPage : TabPage
        {
            public DrawingStandards Standard;
            public StandardTabPage(DrawingStandards _standard) : base(_standard.ToString())
            {
                this.Standard = _standard;
                this.Name = _standard.ToString();
                var flp = new FlowLayoutPanel
                {
                    Name = _standard.ToString(),
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(flp);
            }
        }

        //private class MarkButton : Button
        //{
        //    public int id;
        //}

        public void BindDrawingStandard(DrawingStandards _standard, IList<MarkButtonDTO> _listMarks)
        {
            tabStandards.TabPages.Add(new StandardTabPage(_standard));
            BindMarkButtons(_standard, _listMarks);
        }

        public DrawingStandards GetDrawingStandard()
        {
            return (tabStandards.SelectedTab as StandardTabPage).Standard;
        }

        private void BindMarkButtons(DrawingStandards _standard, IList<MarkButtonDTO> _listMarks)
        {
            var tab = tabStandards.TabPages[_standard.ToString()];
            var flp = tab.Controls[_standard.ToString()] as FlowLayoutPanel;
            flp.Controls.Clear();
            foreach (var item in _listMarks)
            {
                var btn = new Button
                {
                    Tag = item.id,
                    Size = new Size(50, 50),
                    Name = "button_" + item.id,
                    Image = item.picture
                };
                btn.Click += new EventHandler(ButtonClick);
                toolTips.SetToolTip(btn, item.name);
                flp.Controls.Add(btn);
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            Presenter.CreateMark(Convert.ToInt16(button.Tag));
        }

        private void TabChange(object sender, EventArgs e)
        {
            var page = tabStandards.SelectedTab as StandardTabPage;
            Presenter.ChangeStandardDrawing(page.Standard);
        }
    }
}
