﻿using SistemaVenta.DTO;

namespace SistemaVenta.API.Utilidad
{
    public class Response <T>
    {
        internal List<MenuDTO> value;

        public bool status { get; set; }
        public T Value { get; set; }
        public string msg { get; set; }


    }
}
