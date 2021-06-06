using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenMinhTrong_59.Models
{
    public partial class LTQLDb_ : DbContext
    {
        public LTQLDb_()
            : base("name=LTQLDb")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
