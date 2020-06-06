using System.Drawing;
using System.Windows.Forms;
using BulkMailSender.Components;
using BulkMailSender.Core;

namespace BulkMailSender.Views
{
  public class  ViewBase:UserControl
  {
    private IAppRepository _appRepo;
    private IAppService _appSvc;

    protected IAppRepository AppRepo => _appRepo;
    protected IAppService AppSvc => _appSvc;

    public void Initialize(IAppRepository appRepo, IAppService appSvc)
    {
      _appRepo = appRepo;
      _appSvc = appSvc;
      AfterInitialized();
    }

    public virtual void OnClosing()
    {
    }


    protected virtual void AfterInitialized()
    {
    }

    protected void SetNodeSelectionEvidenceIntreeview(TreeView tv)
    {
      tv.DrawMode = TreeViewDrawMode.OwnerDrawText;
      tv.HideSelection = false;
      tv.DrawNode += tv_DrawNode;
    }

    private void tv_DrawNode(object sender, DrawTreeNodeEventArgs e)
    {
      if (e.Node == null) return;

      // if treeview's HideSelection property is "True", 
      // this will always returns "False" on unfocused treeview
      var selected = (e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected;
      var unfocused = !e.Node.TreeView.Focused;

      // we need to do owner drawing only on a selected node
      // and when the treeview is unfocused, else let the OS do it for us
      if (selected && unfocused)
      {
        var font = e.Node.NodeFont ?? e.Node.TreeView.Font;
        e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
        TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, SystemColors.HighlightText, TextFormatFlags.GlyphOverhangPadding);
      }
      else
      {
        e.DrawDefault = true;
      }
    }

    public virtual void Selected()
    {
    }
  }
}