//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VideoGameStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game()
        {
            this.Line_Item = new HashSet<Line_Item>();
            this.Reviews = new HashSet<Review>();
            this.User_Game = new HashSet<User_Game>();
            this.Wish_List = new HashSet<Wish_List>();
        }
    
        public int game_id { get; set; }
        public string game_name { get; set; }
        public string description { get; set; }
        public decimal cost { get; set; }
        public decimal list_price { get; set; }
        public int on_hand { get; set; }
        public int developer_id { get; set; }
        public int publisher_id { get; set; }
        public int genre_id { get; set; }
        public System.DateTime release_date { get; set; }
        public bool is_on_sale { get; set; }
        public bool is_discontinued { get; set; }
        public bool is_downloadable { get; set; }
        public bool is_physical_copy { get; set; }
        public string image_location { get; set; }
    
        public virtual Developer Developer { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Line_Item> Line_Item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Game> User_Game { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wish_List> Wish_List { get; set; }
    }
}
