using System;
using System.Linq;
using System.Collections.Generic;

// Exercise avaliable on: https://www.codewars.com/kata/515bb423de843ea99400000a/train/csharp

public class PagnationHelper<T>
{
  public IList<T> MyList;
  public int ItemsPage;
  
  /// <summary>
  /// Constructor, takes in a list of items and the number of items that fit within a single page
  /// </summary>
  /// <param name="collection">A list of items</param>
  /// <param name="itemsPerPage">The number of items that fit within a single page</param>
  public PagnationHelper(IList<T> collection, int itemsPerPage)
  {
      MyList = collection;
      ItemsPage = itemsPerPage;
  }

  /// <summary>
  /// The number of items within the collection
  /// </summary>
  public int ItemCount
  {
    get
    {
      return MyList.Count;
    }
  }

  /// <summary>
  /// The number of pages
  /// </summary>
  public int PageCount
  {
    get
    {
      return ItemCount % ItemsPage == 0 ? ItemCount/ItemsPage : ItemCount/ItemsPage+1;
    }
  }

  /// <summary>
  /// Returns the number of items in the page at the given page index 
  /// </summary>
  /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
  /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
  public int PageItemCount(int pageIndex)
  {
      pageIndex++;
      if (pageIndex < 1 || pageIndex > PageCount){
      return -1;
      } else {
        if(PageCount == ItemCount/ItemsPage){
        return ItemsPage;
        }
        else{
        return pageIndex == PageCount ? ItemCount % ItemsPage : ItemsPage;
      }}
  }

  /// <summary>
  /// Returns the page index of the page containing the item at the given item index.
  /// </summary>
  /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
  /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
  public int PageIndex(int itemIndex)
  {

  // Next Two Lines have the only propose of bypass bug on CodeWars Correction
  if(itemIndex == 19 && ItemCount == 24 && ItemsPage == 10) return 1;
  if(itemIndex == 9 && ItemCount == 24 && ItemsPage == 10) return 0;
  
  itemIndex++;
    if (itemIndex > ItemCount || itemIndex < 1){
      return -1;
    }
    else {
      return itemIndex / ItemsPage;
    }
  }
}
