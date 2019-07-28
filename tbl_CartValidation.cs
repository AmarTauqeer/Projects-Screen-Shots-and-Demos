using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gentry
{
    public partial class tbl_CartValidation
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public Nullable<int> Price { get; set; }
        public System.DateTime CreatedDateTime { get; set; }
        public string SessionKey { get; set; }

    }
    [MetadataType(typeof(tbl_CartValidation))]
    public partial class tbl_Cart
    {
    } 

}