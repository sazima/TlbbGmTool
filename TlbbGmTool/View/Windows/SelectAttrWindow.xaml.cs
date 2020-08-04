﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using TlbbGmTool.Models;
using TlbbGmTool.ViewModels;

namespace TlbbGmTool.View.Windows
{
    public partial class SelectAttrWindow : Window
    {
        #region Properties

        public int Attr1 { get; set; }
        public int Attr2 { get; set; }

        #endregion

        public SelectAttrWindow(IEnumerable<ItemBase> equipBaseList, int itemBaseId,
            int attr1, int attr2)
        {
            InitializeComponent();
            var equipBaseInfo = (from baseInfo in equipBaseList
                where baseInfo.Id == itemBaseId
                select baseInfo).First();
            GetViewModel().InitData(equipBaseInfo, this, attr1, attr2);
        }

        private SelectAttrViewModel GetViewModel()
        {
            return DataContext as SelectAttrViewModel;
        }
    }
}