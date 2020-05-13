﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace UI.classMD
{
    public class DataGridNumber : DataGrid
    {
        #region datagrid 序号扩展

        public static bool GetDisplayRowNumber(DependencyObject obj)
        {
            return (bool)obj.GetValue(DisplayRowNumberProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(DataGrid))]
        public static void SetDisplayRowNumber(DependencyObject obj, bool value)
        {
            obj.SetValue(DisplayRowNumberProperty, value);
        }

        /// <summary>
        /// 设置是否显示行号
        /// </summary>
        public static readonly DependencyProperty DisplayRowNumberProperty =
            DependencyProperty.RegisterAttached("DisplayRowNumber",
                                                typeof(bool),
                                                typeof(DataGridNumber),
                                                new PropertyMetadata(false, OnDisplayRowNumberChanged));

       
        private static void OnDisplayRowNumberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DataGrid grid = d as DataGrid;
            if (grid == null)
            {
                return;
            }

            if ((bool)e.NewValue)
            {
                grid.LoadingRow += OnGridLoadingRow;
                grid.UnloadingRow += OnGridUnloadingRow;
            }
            else
            {
                grid.LoadingRow -= OnGridLoadingRow;
                grid.UnloadingRow -= OnGridUnloadingRow;
            }
        }

        private static void RefreshDataGridRowNumber(object sender)
        {
            DataGrid grid = sender as DataGrid;
            if (grid == null)
            {
                return;
            }

            foreach (var item in grid.Items)
            {
                var row = (DataGridRow)grid.ItemContainerGenerator.ContainerFromItem(item);
                if (row == null)
                {
                    return;
                }
                row.Header = row.GetIndex() + 1;
            }
        }

        private static void OnGridUnloadingRow(object sender, DataGridRowEventArgs e)
        {
            RefreshDataGridRowNumber(sender);
        }

        private static void OnGridLoadingRow(object sender, DataGridRowEventArgs e)
        {
            RefreshDataGridRowNumber(sender);
        }
        #endregion

    }
}
