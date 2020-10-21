using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POMACSystem.Models
{
    public class CountiesModel
    {
       public IList<SelectListItem> Counties { get; set; }
      public  IList<SelectListItem> SubCounties { get; set; }
      public  IList<SelectListItem> Locations { get; set; }
       public IList<SelectListItem> Sublocations { get; set; }

    }
}