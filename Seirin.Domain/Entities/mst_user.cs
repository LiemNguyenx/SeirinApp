using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Seirin.Domain.Entities
{
    public partial class mst_user
    {
        public string Id { get; set; }
        public string code_cst {get;set;}
        public string login_id { get; set; }
        public string login_pass { get; set; }
        public string loginkey { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public int cnt_login_error { get; set; }
        public int use_flg { get; set; }
        public int display_order { get; set; }
        public int dest_flag { get; set; }
        public string create_by { get; set; }
        public DateTime create_date { get; set; }
        public string modify_by { get; set; }
        public DateTime modify_date { get; set; }
        public string admin_create { get; set; }
        public DateTime admin_modify { get; set; }
    }
}
