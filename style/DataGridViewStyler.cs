using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.style
{
    public static class DataGridViewStyler
    {
        public static void ApplyStyles(DataGridView dataGridView)
        {
            if (dataGridView == null) { return; }

            dataGridView.AccessibleRole = AccessibleRole.Table;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridView.DefaultCellStyle;
            //dataGridView.Anchor = AnchorStyles.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.BackgroundColor = Color.Gray;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CausesValidation = true;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.Gray,
                Font = new Font("Segoe UI", 9),
                ForeColor = SystemColors.Window,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.ControlDark,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                WrapMode = DataGridViewTriState.True

            };
            dataGridView.ColumnHeadersHeight = 30;
            //dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //dataGridView.ColumnHeadersVisible = true;
            //dataGridView.Columns
            //dataGridView.ContextMenuStrip = 
            //dataGridView.Cursor
            //dataGridView.DataMember
            //dataGridView.DataSource
            //dataGridView.DefaultCellStyle
            //dataGridView.Dock
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            //dataGridView.Enabled = true;
            dataGridView.EnableHeadersVisualStyles = false;
            //dataGridView.GenerateMember = true;
            dataGridView.GridColor = Color.LightGray;
            //dataGridView.HighLightPercentage
            //dataGridView.ImeMode = ImeMode.NoControl;
            //dataGridView.Location
            //dataGridView.Locked = false;
            //dataGridView.Margin = 
            //dataGridView.MaximumSize
            //dataGridView.MinimumSize
            //dataGridView.Modifiers =
            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = true;
            //dataGridView.RightToLeft = false;
            //dataGridView.RowHeadersBorderStyle
            //dataGridView.RowHeadersDefaultCellStyle
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 41;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            //dataGridView.RowsDefaultCellStyle
            //dataGridView.RowTemplate
            //dataGridView.ScrollBars
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView.ShowCellErrors = true;
            //dataGridView.ShowCellToolTips = true;
            //dataGridView.ShowEditingIcon = true;
            //dataGridView.ShowRowErrors = true;
            //dataGridView.Size
            //dataGridView.StandardTab = false;
            //dataGridView.TabIndex
            //dataGridView.TabStop = true;
            //dataGridView.Tag
            //dataGridView.Theme
            //dataGridView.UseCustomBackColor
            //dataGridView.UseCustomForeColor
            //dataGridView.UseStyleColors
            //dataGridView.UseWaitCursor
            //dataGridView.VirtualMode = false;
            //dataGridView.Visible = true;
        }
        public static void ApplyStyles(PoisonDataGridView dataGridView)
        {
            if (dataGridView == null) { return; }

            dataGridView.AccessibleRole = AccessibleRole.Table;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridView.DefaultCellStyle;
            //dataGridView.Anchor = AnchorStyles.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.BackgroundColor = Color.Gray;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CausesValidation = true;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.Gray,
                Font = new Font("Segoe UI", 9),
                ForeColor = SystemColors.Window,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.ControlDark,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                WrapMode = DataGridViewTriState.True

            };
            dataGridView.ColumnHeadersHeight = 30;
            //dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            //dataGridView.ColumnHeadersVisible = true;
            //dataGridView.Columns
            //dataGridView.ContextMenuStrip = 
            //dataGridView.Cursor
            //dataGridView.DataMember
            //dataGridView.DataSource
            //dataGridView.DefaultCellStyle
            //dataGridView.Dock
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            //dataGridView.Enabled = true;
            dataGridView.EnableHeadersVisualStyles = false;
            //dataGridView.GenerateMember = true;
            dataGridView.GridColor = Color.LightGray;
            //dataGridView.HighLightPercentage
            //dataGridView.ImeMode = ImeMode.NoControl;
            //dataGridView.Location
            //dataGridView.Locked = false;
            //dataGridView.Margin = 
            //dataGridView.MaximumSize
            //dataGridView.MinimumSize
            //dataGridView.Modifiers =
            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = true;
            //dataGridView.RightToLeft = false;
            //dataGridView.RowHeadersBorderStyle
            //dataGridView.RowHeadersDefaultCellStyle
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 41;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            //dataGridView.RowsDefaultCellStyle
            //dataGridView.RowTemplate
            //dataGridView.ScrollBars
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView.ShowCellErrors = true;
            //dataGridView.ShowCellToolTips = true;
            //dataGridView.ShowEditingIcon = true;
            //dataGridView.ShowRowErrors = true;
            //dataGridView.Size
            //dataGridView.StandardTab = false;
            //dataGridView.TabIndex
            //dataGridView.TabStop = true;
            //dataGridView.Tag
            //dataGridView.Theme
            //dataGridView.UseCustomBackColor
            //dataGridView.UseCustomForeColor
            //dataGridView.UseStyleColors
            //dataGridView.UseWaitCursor
            //dataGridView.VirtualMode = false;
            //dataGridView.Visible = true;
        }
    }
}
