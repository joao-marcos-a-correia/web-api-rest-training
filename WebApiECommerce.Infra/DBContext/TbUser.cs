using System;
using System.Collections.Generic;

namespace WebApiECommerce.Infra
{
    public partial class TbUser
    {
        public int CIduser { get; set; }
        public string CUserName { get; set; }
        public string CPassWord { get; set; }
        public string CEmail { get; set; }
        public byte? LEnabled { get; set; }
    }
}
