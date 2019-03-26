
using System.Collections.Generic;
using Egar.Focus.DealModule.Fields;
using Egar.Focus.Framework.Types;

namespace ConsoleApp1
{
		public class EntityBaseTest_Graph : GraphBase
	{
		(ConsoleApp2.EntityBaseTest)Entity;//полное имя к классу entity 

		public EntityBaseTest_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)//название entity класса +_Graph в качестве имени
		{
			this.Entity= (EntityBaseTest)entity;
		}

		protected override Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
        {
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
				#region input order
				{"", new List<CalcFieldInfo>()
					{//пройдемся по всем значениям дикшнари с зависимостями.
						//1 параметр- Entity.+ тип филда, второй- лист зависимостей
						new CalcFieldInfo(Entity.Fild3, new List<FieldBase>(){Fild1 }),
											}
				}
				#endregion input order
			}
		} 
	}
		public class EntityTest_Graph : GraphBase
	{
		(ConsoleApp2.EntityTest)Entity;//полное имя к классу entity 

		public EntityTest_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)//название entity класса +_Graph в качестве имени
		{
			this.Entity= (EntityTest)entity;
		}

		protected override Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
        {
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
				#region input order
				{"", new List<CalcFieldInfo>()
					{//пройдемся по всем значениям дикшнари с зависимостями.
						//1 параметр- Entity.+ тип филда, второй- лист зависимостей
						new CalcFieldInfo(Entity.Fild1, new List<FieldBase>(){Fild2 }),
											}
				}
				#endregion input order
			}
		} 
	}
		public class Entity_Graph : GraphBase
	{
		(ConsoleApp2.Entity)Entity;//полное имя к классу entity 

		public Entity_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)//название entity класса +_Graph в качестве имени
		{
			this.Entity= (Entity)entity;
		}

		protected override Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
        {
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
				#region input order
				{"", new List<CalcFieldInfo>()
					{//пройдемся по всем значениям дикшнари с зависимостями.
						//1 параметр- Entity.+ тип филда, второй- лист зависимостей
						new CalcFieldInfo(Entity.Fild1, new List<FieldBase>(){Fild2 }),
						//1 параметр- Entity.+ тип филда, второй- лист зависимостей
						new CalcFieldInfo(Entity.Fild3, new List<FieldBase>(){Fild1 ,

Fild2 }),
						//1 параметр- Entity.+ тип филда, второй- лист зависимостей
						new CalcFieldInfo(Entity.TestFild, new List<FieldBase>(){Fild1 }),
						//1 параметр- Entity.+ тип филда, второй- лист зависимостей
						new CalcFieldInfo(Entity.Fild3_1, new List<FieldBase>(){Fild3 }),
											}
				}
				#endregion input order
			}
		} 
	}
	}
// List<ParamInfo> lParamInfo- лист зависимостей филда. параметр типа? передается в сгенерированный лист
