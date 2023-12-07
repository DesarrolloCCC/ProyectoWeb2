namespace model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("db_CCC.ConfigTipos")]
    public partial class ConfigTipos
    {
        public ConfigTipos()
        { }

        //public int pId { get; set; }

        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Descripcion { get; set; }


        public List<ConfigTipos> Listar()
        {
            var pTipos = new List<ConfigTipos>();
            try
            {
                using (var CLBCtx = new CLUBPRBContext())
                {
                    pTipos = CLBCtx.ConfigTipos.ToList();
                    pTipos.Sort((i1, i2) => i1.Id.CompareTo(i2.Id));
                }
            }
            catch (Exception E)
            { throw; }
            return pTipos;
        }

        //public ConfigTipos BuscarID(int pid)
        //{
        //    var resp = new ConfigTipos();
        //    try
        //    {
        //        using (var CLBCtx = new CLUBPRBContext())
        //        {
        //            resp = CLBCtx.ConfigTipos.Where(x => x.Id == pid)
        //                .SingleOrDefault();
        //        }
        //    }
        //    catch (Exception E)
        //    {
        //        throw;
        //    }
        //    return resp;
        //}

    }
}
