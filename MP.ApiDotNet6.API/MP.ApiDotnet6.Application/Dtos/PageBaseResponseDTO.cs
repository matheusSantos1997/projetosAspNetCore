using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotnet6.Application.Dtos
{
    public class PageBaseResponseDTO<T>
    {
        public PageBaseResponseDTO(int totalRegister, List<T> data)
        {
            TotalRegister = totalRegister;
            Data = data;
        }

        public int TotalRegister { get; private set; }

        public List<T> Data { get; private set; }
    }
}
