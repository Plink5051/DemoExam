//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuildingMaterials.ViewModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int OrderStatusID { get; set; }
        public System.DateTime OrderDeliveryDate { get; set; }
        public int OrderPickupPointID { get; set; }
        public int UserID { get; set; }
        public int CodeToReceive { get; set; }
        public System.DateTime OrderDatedatetime { get; set; }
    
        public virtual OrderPickupPoint OrderPickupPoint { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual User User { get; set; }
    }
}
