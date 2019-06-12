

using System.Collections.Generic;
using Egar.Focus.DealModule.Fields;
using Egar.Focus.Framework.Types;

namespace GraphGeneratorUtil
{
		
	public class FieldsEntity_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.FieldsEntity)Entity;

		public FieldsEntity_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FieldsEntity)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion input order
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class FieldsEntity_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.FieldsEntity)Entity;

		public FieldsEntity_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FieldsEntity)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(changedField, new List<FieldBase>(){}),
							new CalcFieldInfo(fld, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region changedField
                {"changedField", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion changedField
						
				

				
				#region fld
                {"fld", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion fld
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
}
