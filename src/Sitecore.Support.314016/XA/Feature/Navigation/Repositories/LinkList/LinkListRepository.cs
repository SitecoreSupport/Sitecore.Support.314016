namespace Sitecore.Support.XA.Feature.Navigation.Repositories.LinkList
{
  using Sitecore.Data.Items;
  using Sitecore.XA.Foundation.Mvc.Repositories.Base;
  using Sitecore.XA.Foundation.RenderingVariants.Models;
  using System.Collections.Generic;
  using System.Linq;

  public class LinkListRepository : Sitecore.XA.Feature.Navigation.Repositories.LinkList.LinkListRepository
  {
    public override IRenderingModelBase GetModel()
    {
      VariantListsRenderingModel m = new VariantListsRenderingModel();
      this.FillBaseProperties(m);
      #region Changed code
      m.Items = this.GetItemsAllLanguages(); 
      #endregion
      return m;
    }

    private IEnumerable<Item> GetItemsAllLanguages()
    {
      Item dataSourceItem = this.Rendering.DataSourceItem;
      Item item = dataSourceItem ?? this.PageContext.Current;
      #region Changed code
      return ((item == null) ? Enumerable.Empty<Item>() : item.GetChildren()); // Using GetChildren instead of GetChildrenWithVersion 
      #endregion
    }
  }
}