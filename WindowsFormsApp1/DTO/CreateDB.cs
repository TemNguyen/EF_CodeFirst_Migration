using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1.DTO
{
    class CreateDB : CreateDatabaseIfNotExists<CSDL>
    {
        protected override void Seed(CSDL context)
        {
            context.SVs.AddRange(new SV[]
            {
                new SV() {MSSV = "1", NameSV = "NVA", ID_Lop = 1},
                new SV() {MSSV = "2", NameSV = "NVB", ID_Lop = 2},
                new SV() {MSSV = "3", NameSV = "NVC", ID_Lop = 1}
            });

            context.LSHes.AddRange(new LSH[]
            {
                new LSH() {ID_Lop = 1, NameLop = "CNTT"},
                new LSH() {ID_Lop = 2, NameLop = "DTVT"}
            });
        }
    }
}
