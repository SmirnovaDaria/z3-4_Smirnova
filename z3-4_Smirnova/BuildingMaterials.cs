//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace z3_4_Smirnova
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuildingMaterials
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Nullable<int> UnitID { get; set; }
        public Nullable<int> Remains { get; set; }
        public Nullable<int> WarehouseID { get; set; }
    
        public virtual Unit Unit { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
