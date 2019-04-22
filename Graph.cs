
using System.Collections.Generic;
using Egar.Focus.DealModule.Fields;
using Egar.Focus.Framework.Types;

namespace ConsoleApp1
{
		
	public class EntityyTest4_Graph : GraphBase
	{	
		(ConsoleApp2.EntityyTest4)Entity;

		public EntityyTest4_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (EntityyTest4)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild1, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region fild1
                {"fild1", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion fild1
						
				

				
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
	
	public class EntityTest3_Graph : GraphBase
	{	
		(ConsoleApp2.EntityTest3)Entity;

		public EntityTest3_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (EntityTest3)entity;
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
							new CalcFieldInfo(fild1, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region fild3
                {"fild3", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild1, new List<FieldBase>(){}),
	
					}
				},
				#endregion fild3
						
				

				
				#region fild1
                {"fild1", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion fild1
						
				

				
			
			};//new Dictionary
		 }
	return calcOrder;
		}
	}
		#endregion //define order
	
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
	
	public class EntityTest2_Graph : GraphBase
	{	
		(ConsoleApp2.EntityTest2)Entity;

		public EntityTest2_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (EntityTest2)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild1, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region fild1
                {"fild1", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion fild1
						
				

				
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
	
	public class EntityTest_Graph : GraphBase
	{	
		(ConsoleApp2.EntityTest)Entity;

		public EntityTest_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (EntityTest)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild1, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region fild1
                {"fild1", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion fild1
						
				

				
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
										new CalcFieldInfo(fild1, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region fild1
                {"fild1", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(fild3, new List<FieldBase>(){}),
							new CalcFieldInfo(fild3_1, new List<FieldBase>(){}),
							new CalcFieldInfo(testFild, new List<FieldBase>(){}),
	
					}
				},
				#endregion fild1
						
				

				
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
