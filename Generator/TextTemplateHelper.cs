using ConsoleApp1.InfoClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generator
{
    partial class TextTemplate
    {
        private List<EntityInfo> entityInfos;

        public TextTemplate(List<EntityInfo> entityInfos)
        {
            this.entityInfos = entityInfos; 
        }
    }
}
