
using System.Collections.Generic;
using Egar.Focus.DealModule.Fields;
using Egar.Focus.Framework.Types;

namespace ConsoleApp1
{
		
	public class EntityBaseTest_Graph : GraphBase
	{	
		(ConsoleApp2.EntityBaseTest)Entity;

		public EntityBaseTest_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (EntityBaseTest)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild3, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region fild3
                {"fild3", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion fild3
						
				

				
			
			};//new Dictionary
		 }
	return calcOrder;
		}
	}
		#endregion //define order
	
	public class Entity_Graph : GraphBase
	{	
		(ConsoleApp2.Entity)Entity;

		public Entity_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (Entity)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Fild1, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Fild1
                {"Fild1", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion Fild1
						
				

				
				#region fild3
                {"fild3", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion fild3
						
				

				
				#region testFild
                {"testFild", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion testFild
						
				

				
				#region fild3_1
                {"fild3_1", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion fild3_1
						
				

				
			
			};//new Dictionary
		 }
	return calcOrder;
		}
	}
		#endregion //define order
				
				
	}
}
