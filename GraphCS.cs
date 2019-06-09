

using System.Collections.Generic;
using Egar.Focus.DealModule.Fields;
using Egar.Focus.Framework.Types;

namespace GraphGeneratorUtil
{
		
	public class FutureInitiationEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.Futures.FutureInitiationEvent)Entity;

		public FutureInitiationEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureInitiationEvent)entity;
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
	
	public class FutureInitiationEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.Futures.FutureInitiationEventGen)Entity;

		public FutureInitiationEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureInitiationEventGen)entity;
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
	
	public class FutureEventBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.Futures.FutureEventBase)Entity;

		public FutureEventBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureEventBase)entity;
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
	
	public class FutureEventBaseGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.Futures.FutureEventBaseGen)Entity;

		public FutureEventBaseGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureEventBaseGen)entity;
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
	
	public class LoanSecuritiesFreePayFeeEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesFreePayFeeEvent)Entity;

		public LoanSecuritiesFreePayFeeEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesFreePayFeeEvent)entity;
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
	
	public class LoanSecuritiesFreeReceiveFeeEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesFreeReceiveFeeEvent)Entity;

		public LoanSecuritiesFreeReceiveFeeEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesFreeReceiveFeeEvent)entity;
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
	
	public class LoanSecuritiesFreeReceiveEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesFreeReceiveEvent)Entity;

		public LoanSecuritiesFreeReceiveEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesFreeReceiveEvent)entity;
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
	
	public class LoanSecuritiesFreePayEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesFreePayEvent)Entity;

		public LoanSecuritiesFreePayEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesFreePayEvent)entity;
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
	
	public class LoanSecuritiesFreeEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesFreeEventGen)Entity;

		public LoanSecuritiesFreeEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesFreeEventGen)entity;
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
	
	public class LoanSecuritiesAmzEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesAmzEvent)Entity;

		public LoanSecuritiesAmzEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesAmzEvent)entity;
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
	
	public class LoanSecuritiesExerciseEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesExerciseEvent)Entity;

		public LoanSecuritiesExerciseEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesExerciseEvent)entity;
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
	
	public class LoanSecuritiesExerciseEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesExerciseEventGen)Entity;

		public LoanSecuritiesExerciseEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesExerciseEventGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(QtyItems, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region QtyItems
                {"QtyItems", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion QtyItems
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesHorizontEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesHorizontEvent)Entity;

		public LoanSecuritiesHorizontEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesHorizontEvent)entity;
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
	
	public class LoanSecuritiesHorizontEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesHorizontEventGen)Entity;

		public LoanSecuritiesHorizontEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesHorizontEventGen)entity;
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
	
	public class LoanSecuritiesRateChangeScheduledEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesRateChangeScheduledEvent)Entity;

		public LoanSecuritiesRateChangeScheduledEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesRateChangeScheduledEvent)entity;
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
	
	public class LoanSecuritiesRateChangeScheduledEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesRateChangeScheduledEventGen)Entity;

		public LoanSecuritiesRateChangeScheduledEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesRateChangeScheduledEventGen)entity;
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
	
	public class LoanSecuritiesRateChangeEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesRateChangeEvent)Entity;

		public LoanSecuritiesRateChangeEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesRateChangeEvent)entity;
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
	
	public class LoanSecuritiesResetRateEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesResetRateEvent)Entity;

		public LoanSecuritiesResetRateEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesResetRateEvent)entity;
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
	
	public class LoanSecuritiesResetRateEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesResetRateEventGen)Entity;

		public LoanSecuritiesResetRateEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesResetRateEventGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ReferenceRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Spread, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRate, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region ReferenceRate
                {"ReferenceRate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Spread, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRate, new List<FieldBase>(){}),
	
					}
				},
				#endregion ReferenceRate
						
				

				
				#region Spread
                {"Spread", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ResetRate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Spread
						
				

				
				#region ResetRate
                {"ResetRate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ResetRate
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesSecuritiesReceiveEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesSecuritiesReceiveEvent)Entity;

		public LoanSecuritiesSecuritiesReceiveEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesSecuritiesReceiveEvent)entity;
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
	
	public class LoanSecuritiesSecuritiesPayEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesSecuritiesPayEventGen)Entity;

		public LoanSecuritiesSecuritiesPayEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesSecuritiesPayEventGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Quantity, new List<FieldBase>(){}),
							new CalcFieldInfo(QtyChange, new List<FieldBase>(){}),
							new CalcFieldInfo(QtyItemsChange, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Quantity
                {"Quantity", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Quantity
						
				

				
				#region QtyChange
                {"QtyChange", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(QtyItemsChange, new List<FieldBase>(){}),
	
					}
				},
				#endregion QtyChange
						
				

				
				#region QtyItemsChange
                {"QtyItemsChange", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion QtyItemsChange
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesSecuritiesPayEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesSecuritiesPayEvent)Entity;

		public LoanSecuritiesSecuritiesPayEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesSecuritiesPayEvent)entity;
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
	
	public class LoanSecuritiesRateChangeEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesRateChangeEventGen)Entity;

		public LoanSecuritiesRateChangeEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesRateChangeEventGen)entity;
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
	
	public class LoanSecuritiesValuationEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesValuationEvent)Entity;

		public LoanSecuritiesValuationEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesValuationEvent)entity;
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
	
	public class LoanSecuritiesInterestPaymentEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesInterestPaymentEvent)Entity;

		public LoanSecuritiesInterestPaymentEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesInterestPaymentEvent)entity;
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
	
	public class LoanSecuritiesValuationEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesValuationEventGen)Entity;

		public LoanSecuritiesValuationEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesValuationEventGen)entity;
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
	
	public class LoanSecuritiesInterestPaymentEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesInterestPaymentEventGen)Entity;

		public LoanSecuritiesInterestPaymentEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesInterestPaymentEventGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Payment, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CalcPeriodDays, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Payment
                {"Payment", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(CalcPeriodDays, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentInfo, new List<FieldBase>(){}),
	
					}
				},
				#endregion Payment
						
				

				
				#region InterestPaymentInfo
                {"InterestPaymentInfo", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion InterestPaymentInfo
						
				

				
				#region CalcPeriodDays
                {"CalcPeriodDays", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CalcPeriodDays
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesCpnEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesCpnEvent)Entity;

		public LoanSecuritiesCpnEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesCpnEvent)entity;
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
	
	public class LoanSecuritiesEventBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesEventBase)Entity;

		public LoanSecuritiesEventBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesEventBase)entity;
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
	
	public class LoanSecuritiesCpnAmzEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesCpnAmzEventGen)Entity;

		public LoanSecuritiesCpnAmzEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesCpnAmzEventGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Payment, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Payment
                {"Payment", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Payment
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesInitiationEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesInitiationEvent)Entity;

		public LoanSecuritiesInitiationEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesInitiationEvent)entity;
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
	
	public class LoanSecuritiesEventBaseGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesEventBaseGen)Entity;

		public LoanSecuritiesEventBaseGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesEventBaseGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(AmountBase, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EstimatedInterestDue, new List<FieldBase>(){}),
							new CalcFieldInfo(EventDays, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestDue, new List<FieldBase>(){}),
							new CalcFieldInfo(RateDays, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region AmountBase
                {"AmountBase", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(InterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(RateDays, new List<FieldBase>(){}),
							new CalcFieldInfo(EventDays, new List<FieldBase>(){}),
							new CalcFieldInfo(EstimatedInterestDue, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestDue, new List<FieldBase>(){}),
	
					}
				},
				#endregion AmountBase
						
				

				
				#region InterestDate
                {"InterestDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(RateDays, new List<FieldBase>(){}),
							new CalcFieldInfo(EventDays, new List<FieldBase>(){}),
							new CalcFieldInfo(EstimatedInterestDue, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestDue, new List<FieldBase>(){}),
	
					}
				},
				#endregion InterestDate
						
				

				
				#region InterestDue
                {"InterestDue", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion InterestDue
						
				

				
				#region EstimatedInterestDue
                {"EstimatedInterestDue", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion EstimatedInterestDue
						
				

				
				#region EventDays
                {"EventDays", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion EventDays
						
				

				
				#region RateDays
                {"RateDays", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion RateDays
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesInitiationEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.LoanSecurities.LoanSecuritiesInitiationEventGen)Entity;

		public LoanSecuritiesInitiationEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesInitiationEventGen)entity;
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
	
	public class OptionETEventBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.OptionsET.OptionETEventBase)Entity;

		public OptionETEventBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETEventBase)entity;
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
	
	public class OptionETEventBaseGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.OptionsET.OptionETEventBaseGen)Entity;

		public OptionETEventBaseGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETEventBaseGen)entity;
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
	
	public class OptionETInitiationEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.OptionsET.OptionETInitiationEvent)Entity;

		public OptionETInitiationEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETInitiationEvent)entity;
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
	
	public class OptionETInitiationEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.OptionsET.OptionETInitiationEventGen)Entity;

		public OptionETInitiationEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETInitiationEventGen)entity;
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
	
	public class PNoteInitiationEventGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.PNote.PNoteInitiationEventGen)Entity;

		public PNoteInitiationEventGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (PNoteInitiationEventGen)entity;
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
	
	public class PNoteInitiationEvent_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.PNote.PNoteInitiationEvent)Entity;

		public PNoteInitiationEvent_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (PNoteInitiationEvent)entity;
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
	
	public class DealEventBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.DealEventBase)Entity;

		public DealEventBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (DealEventBase)entity;
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
	
	public class DealEventGeneric_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.DealEventGeneric)Entity;

		public DealEventGeneric_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (DealEventGeneric)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region RegistrationDate
                {"RegistrationDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion RegistrationDate
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class DealEventGenericImpl_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.DealEvents.DealEventGenericImpl)Entity;

		public DealEventGenericImpl_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (DealEventGenericImpl)entity;
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
	
	public class FutureBond_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.FutureBond)Entity;

		public FutureBond_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureBond)entity;
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
	
	public class FutureEQ_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.FutureEQ)Entity;

		public FutureEQ_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureEQ)entity;
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
	
	public class FutureBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.FutureBase)Entity;

		public FutureBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureBase)entity;
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
	
	public class FutureBaseGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.FutureBaseGen)Entity;

		public FutureBaseGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureBaseGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Underlying, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(Contract, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionExchangeCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementType, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(Custodian, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionClearingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloor, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region ClearingHouseAccount
                {"ClearingHouseAccount", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ComissionExchangeCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Underlying, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Contract, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementType, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloor, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionClearingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(Custodian, new List<FieldBase>(){}),
	
					}
				},
				#endregion ClearingHouseAccount
						
				

				
				#region Custodian
                {"Custodian", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Custodian
						
				

				
				#region ScaleList
                {"ScaleList", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ScaleList
						
				

				
				#region BrokerComissionCcy
                {"BrokerComissionCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionCcy
						
				

				
				#region BrokerComissionConvRate
                {"BrokerComissionConvRate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionConvRate
						
				

				
				#region BrokerComission
                {"BrokerComission", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComission
						
				

				
				#region BrokerComissionPercent
                {"BrokerComissionPercent", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionPercent
						
				

				
				#region BrokerComissionNumber
                {"BrokerComissionNumber", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionNumber
						
				

				
				#region CommissionAccount
                {"CommissionAccount", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CommissionAccount
						
				

				
				#region ComissionExchangeCcy
                {"ComissionExchangeCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Underlying, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Contract, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementType, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloor, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionClearingCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion ComissionExchangeCcy
						
				

				
				#region ComissionClearingCcy
                {"ComissionClearingCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ComissionClearingCcy
						
				

				
				#region TradeFloor
                {"TradeFloor", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion TradeFloor
						
				

				
				#region Holidays
                {"Holidays", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Holidays
						
				

				
				#region SettlementType
                {"SettlementType", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion SettlementType
						
				

				
				#region Underlying
                {"Underlying", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Contract, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
	
					}
				},
				#endregion Underlying
						
				

				
				#region InstrCcy
                {"InstrCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Contract, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
	
					}
				},
				#endregion InstrCcy
						
				

				
				#region Isin
                {"Isin", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Isin
						
				

				
				#region Contract
                {"Contract", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Contract
						
				

				
				#region SetContractDate
                {"SetContractDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion SetContractDate
						
				

				
				#region PriceFrac
                {"PriceFrac", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
	
					}
				},
				#endregion PriceFrac
						
				

				
				#region AmountQuote
                {"AmountQuote", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Price, new List<FieldBase>(){}),
	
					}
				},
				#endregion AmountQuote
						
				

				
				#region Price
                {"Price", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Price
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class FutureFX_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.FutureFX)Entity;

		public FutureFX_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (FutureFX)entity;
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
	
	public class LoanSecuritiesBondB2BGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesBondB2BGen)Entity;

		public LoanSecuritiesBondB2BGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesBondB2BGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Branch, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Branch
                {"Branch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Branch
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesBondB2B_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesBondB2B)Entity;

		public LoanSecuritiesBondB2B_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesBondB2B)entity;
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
	
	public class LoanSecuritiesBondBr2BrGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesBondBr2BrGen)Entity;

		public LoanSecuritiesBondBr2BrGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesBondBr2BrGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(CustodianAccount_SecondBranch, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount_SecondBranch, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region CustodianAccount_SecondBranch
                {"CustodianAccount_SecondBranch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CustodianAccount_SecondBranch
						
				

				
				#region ClearingHouseAccount_SecondBranch
                {"ClearingHouseAccount_SecondBranch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ClearingHouseAccount_SecondBranch
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesBondBr2Br_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesBondBr2Br)Entity;

		public LoanSecuritiesBondBr2Br_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesBondBr2Br)entity;
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
	
	public class LoanSecuritiesBond_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesBond)Entity;

		public LoanSecuritiesBond_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesBond)entity;
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
	
	public class LoanSecuritiesEquityB2B_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesEquityB2B)Entity;

		public LoanSecuritiesEquityB2B_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesEquityB2B)entity;
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
	
	public class LoanSecuritiesEquityB2BGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesEquityB2BGen)Entity;

		public LoanSecuritiesEquityB2BGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesEquityB2BGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Branch, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Branch
                {"Branch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Branch
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesEquityBr2Br_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesEquityBr2Br)Entity;

		public LoanSecuritiesEquityBr2Br_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesEquityBr2Br)entity;
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
	
	public class LoanSecuritiesEquityBr2BrGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesEquityBr2BrGen)Entity;

		public LoanSecuritiesEquityBr2BrGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesEquityBr2BrGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(CustodianAccount_SecondBranch, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount_SecondBranch, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region CustodianAccount_SecondBranch
                {"CustodianAccount_SecondBranch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CustodianAccount_SecondBranch
						
				

				
				#region ClearingHouseAccount_SecondBranch
                {"ClearingHouseAccount_SecondBranch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ClearingHouseAccount_SecondBranch
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesEQ_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesEQ)Entity;

		public LoanSecuritiesEQ_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesEQ)entity;
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
	
	public class LoanSecuritiesBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesBase)Entity;

		public LoanSecuritiesBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesBase)entity;
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
	
	public class LoanSecuritiesBaseGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesBaseGen)Entity;

		public LoanSecuritiesBaseGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesBaseGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(Underlying, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(Qty, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkResetRateTo, new List<FieldBase>(){}),
							new CalcFieldInfo(Benchmark, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region ClearingHouseAccount
                {"ClearingHouseAccount", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ClearingHouseAccount
						
				

				
				#region ValueDate
                {"ValueDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(Underlying, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(Qty, new List<FieldBase>(){}),
							new CalcFieldInfo(Benchmark, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkResetRateTo, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
	
					}
				},
				#endregion ValueDate
						
				

				
				#region DaysToValue
                {"DaysToValue", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion DaysToValue
						
				

				
				#region BrokerComissionCcy
                {"BrokerComissionCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionCcy
						
				

				
				#region BrokerComissionConvRate
                {"BrokerComissionConvRate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionConvRate
						
				

				
				#region BrokerComission
                {"BrokerComission", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComission
						
				

				
				#region BrokerComissionPercent
                {"BrokerComissionPercent", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionPercent
						
				

				
				#region BrokerComissionNumber
                {"BrokerComissionNumber", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionNumber
						
				

				
				#region Holidays
                {"Holidays", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Underlying, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(Qty, new List<FieldBase>(){}),
							new CalcFieldInfo(Benchmark, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkResetRateTo, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Holidays
						
				

				
				#region Underlying
                {"Underlying", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(Qty, new List<FieldBase>(){}),
							new CalcFieldInfo(Benchmark, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkResetRateTo, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Underlying
						
				

				
				#region InstrCcy
                {"InstrCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(Qty, new List<FieldBase>(){}),
							new CalcFieldInfo(Benchmark, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkResetRateTo, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion InstrCcy
						
				

				
				#region Isin
                {"Isin", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Qty, new List<FieldBase>(){}),
							new CalcFieldInfo(Benchmark, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkResetRateTo, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Isin
						
				

				
				#region Qty
                {"Qty", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Benchmark, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkResetRateTo, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Qty
						
				

				
				#region Benchmark
                {"Benchmark", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(LinkResetRateTo, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Benchmark
						
				

				
				#region LinkResetRateTo
                {"LinkResetRateTo", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ResetRateFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion LinkResetRateTo
						
				

				
				#region ResetRateFrequency
                {"ResetRateFrequency", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(LinkRateChangeTo, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateSpread, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysAfterReset, new List<FieldBase>(){}),
							new CalcFieldInfo(ResetRateStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion ResetRateFrequency
						
				

				
				#region ResetRateStartDate
                {"ResetRateStartDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ResetRateStartDate
						
				

				
				#region DaysAfterReset
                {"DaysAfterReset", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion DaysAfterReset
						
				

				
				#region ResetRateSpread
                {"ResetRateSpread", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ResetRateSpread
						
				

				
				#region LinkRateChangeTo
                {"LinkRateChangeTo", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion LinkRateChangeTo
						
				

				
				#region PaymentCcy
                {"PaymentCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(RateChangeFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion PaymentCcy
						
				

				
				#region RateChangeFrequency
                {"RateChangeFrequency", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(StartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Basis, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeAveragingMethod, new List<FieldBase>(){}),
							new CalcFieldInfo(RateChangeStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion RateChangeFrequency
						
				

				
				#region RateChangeStartDate
                {"RateChangeStartDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion RateChangeStartDate
						
				

				
				#region RateChangeAveragingMethod
                {"RateChangeAveragingMethod", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion RateChangeAveragingMethod
						
				

				
				#region Basis
                {"Basis", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Basis
						
				

				
				#region StartDate
                {"StartDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(DayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
	
					}
				},
				#endregion StartDate
						
				

				
				#region Price
                {"Price", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Price
						
				

				
				#region DayRule
                {"DayRule", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(HolidaysCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion DayRule
						
				

				
				#region HolidaysCcy
                {"HolidaysCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(InterestPaymentFrequency, new List<FieldBase>(){}),
							new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion HolidaysCcy
						
				

				
				#region InterestPaymentFrequency
                {"InterestPaymentFrequency", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(UnderlyingInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(InterestWithoutDayRule, new List<FieldBase>(){}),
							new CalcFieldInfo(OperationStartDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion InterestPaymentFrequency
						
				

				
				#region OperationStartDate
                {"OperationStartDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion OperationStartDate
						
				

				
				#region InterestWithoutDayRule
                {"InterestWithoutDayRule", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion InterestWithoutDayRule
						
				

				
				#region UnderlyingInfo
                {"UnderlyingInfo", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion UnderlyingInfo
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesBondGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesBondGen)Entity;

		public LoanSecuritiesBondGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesBondGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Qty, new List<FieldBase>(){}),
							new CalcFieldInfo(QtyItems, new List<FieldBase>(){}),
							new CalcFieldInfo(Accrued, new List<FieldBase>(){}),
							new CalcFieldInfo(QtyUnits, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Qty
                {"Qty", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(QtyItems, new List<FieldBase>(){}),
							new CalcFieldInfo(Accrued, new List<FieldBase>(){}),
							new CalcFieldInfo(QtyUnits, new List<FieldBase>(){}),
	
					}
				},
				#endregion Qty
						
				

				
				#region QtyUnits
                {"QtyUnits", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion QtyUnits
						
				

				
				#region QtyItems
                {"QtyItems", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Accrued, new List<FieldBase>(){}),
	
					}
				},
				#endregion QtyItems
						
				

				
				#region Accrued
                {"Accrued", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Accrued
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class LoanSecuritiesEQGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.LoanSecuritiesEQGen)Entity;

		public LoanSecuritiesEQGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (LoanSecuritiesEQGen)entity;
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
	
	public class OptionETBondFuture_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETBondFuture)Entity;

		public OptionETBondFuture_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETBondFuture)entity;
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
	
	public class OptionETBondFutureGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETBondFutureGen)Entity;

		public OptionETBondFutureGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETBondFutureGen)entity;
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
	
	public class OptionETEquityFutureGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETEquityFutureGen)Entity;

		public OptionETEquityFutureGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETEquityFutureGen)entity;
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
	
	public class OptionETEquityFuture_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETEquityFuture)Entity;

		public OptionETEquityFuture_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETEquityFuture)entity;
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
	
	public class OptionETEquity_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETEquity)Entity;

		public OptionETEquity_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETEquity)entity;
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
	
	public class OptionETEquityGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETEquityGen)Entity;

		public OptionETEquityGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETEquityGen)entity;
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
	
	public class OptionETFXFuture_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETFXFuture)Entity;

		public OptionETFXFuture_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETFXFuture)entity;
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
	
	public class OptionETBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETBase)Entity;

		public OptionETBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETBase)entity;
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
	
	public class OptionETBaseGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.OptionETBaseGen)Entity;

		public OptionETBaseGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (OptionETBaseGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumCCY, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionContract, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ExpiryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionStyle, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumPricingCcyPair, new List<FieldBase>(){}),
							new CalcFieldInfo(Custodian, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Strike, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionClearingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region ClearingHouseAccount
                {"ClearingHouseAccount", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionContract, new List<FieldBase>(){}),
							new CalcFieldInfo(ExpiryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumCCY, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumPricingCcyPair, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Strike, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionStyle, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionClearingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(Custodian, new List<FieldBase>(){}),
	
					}
				},
				#endregion ClearingHouseAccount
						
				

				
				#region Custodian
                {"Custodian", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Custodian
						
				

				
				#region ScaleList
                {"ScaleList", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ScaleList
						
				

				
				#region BrokerComissionCcy
                {"BrokerComissionCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionCcy
						
				

				
				#region BrokerCommissionDate
                {"BrokerCommissionDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerCommissionDate
						
				

				
				#region BrokerComissionConvRate
                {"BrokerComissionConvRate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionConvRate
						
				

				
				#region BrokerComission
                {"BrokerComission", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComission
						
				

				
				#region BrokerComissionPercent
                {"BrokerComissionPercent", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionPercent
						
				

				
				#region BrokerComissionNumber
                {"BrokerComissionNumber", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionNumber
						
				

				
				#region CommissionAccount
                {"CommissionAccount", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CommissionAccount
						
				

				
				#region ComissionClearingCcy
                {"ComissionClearingCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ComissionClearingCcy
						
				

				
				#region Holidays
                {"Holidays", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionContract, new List<FieldBase>(){}),
							new CalcFieldInfo(ExpiryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumCCY, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumPricingCcyPair, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Strike, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionStyle, new List<FieldBase>(){}),
							new CalcFieldInfo(Isin, new List<FieldBase>(){}),
	
					}
				},
				#endregion Holidays
						
				

				
				#region Isin
                {"Isin", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Isin
						
				

				
				#region InstrCcy
                {"InstrCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(OptionContract, new List<FieldBase>(){}),
							new CalcFieldInfo(ExpiryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumCCY, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumPricingCcyPair, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Strike, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionStyle, new List<FieldBase>(){}),
	
					}
				},
				#endregion InstrCcy
						
				

				
				#region OptionContract
                {"OptionContract", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ExpiryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumCCY, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumPricingCcyPair, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Strike, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionStyle, new List<FieldBase>(){}),
	
					}
				},
				#endregion OptionContract
						
				

				
				#region ExpiryDate
                {"ExpiryDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(AmountQuote, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumCCY, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumPricingCcyPair, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Strike, new List<FieldBase>(){}),
							new CalcFieldInfo(OptionStyle, new List<FieldBase>(){}),
	
					}
				},
				#endregion ExpiryDate
						
				

				
				#region OptionStyle
                {"OptionStyle", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion OptionStyle
						
				

				
				#region Strike
                {"Strike", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Strike
						
				

				
				#region AmountQuote
                {"AmountQuote", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(PremiumCCY, new List<FieldBase>(){}),
							new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumPricingCcyPair, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion AmountQuote
						
				

				
				#region PremiumDate
                {"PremiumDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion PremiumDate
						
				

				
				#region PremiumCCY
                {"PremiumCCY", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(PriceFrac, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
							new CalcFieldInfo(PremiumPricingCcyPair, new List<FieldBase>(){}),
	
					}
				},
				#endregion PremiumCCY
						
				

				
				#region PremiumPricingCcyPair
                {"PremiumPricingCcyPair", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion PremiumPricingCcyPair
						
				

				
				#region PriceFrac
                {"PriceFrac", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(PremiumInPricingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion PriceFrac
						
				

				
				#region PremiumInPricingCcy
                {"PremiumInPricingCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Deal2PaymRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion PremiumInPricingCcy
						
				

				
				#region Deal2PaymRate
                {"Deal2PaymRate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Premium, new List<FieldBase>(){}),
							new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Deal2PaymRate
						
				

				
				#region Premium
                {"Premium", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(SettlementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Premium
						
				

				
				#region SettlementDate
                {"SettlementDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(SetContractDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion SettlementDate
						
				

				
				#region SetContractDate
                {"SetContractDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion SetContractDate
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class SpotForwardPNoteB2B_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.SpotForwardPNoteB2B)Entity;

		public SpotForwardPNoteB2B_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (SpotForwardPNoteB2B)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Branch, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Branch
                {"Branch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Branch
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class SpotForwardPNoteB2BImpl_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.SpotForwardPNoteB2BImpl)Entity;

		public SpotForwardPNoteB2BImpl_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (SpotForwardPNoteB2BImpl)entity;
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
	
	public class SpotForwardPNoteBr2Br_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.SpotForwardPNoteBr2Br)Entity;

		public SpotForwardPNoteBr2Br_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (SpotForwardPNoteBr2Br)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(CustodianAccount_SecondBranch, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount_SecondBranch, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region CustodianAccount_SecondBranch
                {"CustodianAccount_SecondBranch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CustodianAccount_SecondBranch
						
				

				
				#region ClearingHouseAccount_SecondBranch
                {"ClearingHouseAccount_SecondBranch", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ClearingHouseAccount_SecondBranch
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class SpotForwardPNoteBr2BrImpl_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.SpotForwardPNoteBr2BrImpl)Entity;

		public SpotForwardPNoteBr2BrImpl_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (SpotForwardPNoteBr2BrImpl)entity;
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
	
	public class DealBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.DealBase)Entity;

		public DealBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (DealBase)entity;
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
	
	public class DealGeneric_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.DealGeneric)Entity;

		public DealGeneric_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (DealGeneric)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(Counterparty, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementType, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(IsDealWithoutMasterAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(IsStandard, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeTime, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(IsForMargin, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region IsStandard
                {"IsStandard", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(TradeTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Counterparty, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementType, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(IsDealWithoutMasterAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(IsForMargin, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion IsStandard
						
				

				
				#region TradeTime
                {"TradeTime", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Counterparty, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementType, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(IsDealWithoutMasterAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(IsForMargin, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion TradeTime
						
				

				
				#region Counterparty
                {"Counterparty", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(MasterAgreementType, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(IsDealWithoutMasterAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(IsForMargin, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Counterparty
						
				

				
				#region MasterAgreementType
                {"MasterAgreementType", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(MasterAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(IsDealWithoutMasterAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(IsForMargin, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion MasterAgreementType
						
				

				
				#region MasterAgreementNum
                {"MasterAgreementNum", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(IsDealWithoutMasterAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(IsForMargin, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
							new CalcFieldInfo(MasterAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion MasterAgreementNum
						
				

				
				#region MasterAgreementDate
                {"MasterAgreementDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion MasterAgreementDate
						
				

				
				#region IsDealWithoutMasterAgreement
                {"IsDealWithoutMasterAgreement", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(IsForMargin, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion IsDealWithoutMasterAgreement
						
				

				
				#region IsForMargin
                {"IsForMargin", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(MarginSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion IsForMargin
						
				

				
				#region MarginSystem
                {"MarginSystem", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(MarginAgreementNum, new List<FieldBase>(){}),
							new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion MarginSystem
						
				

				
				#region MarginAgreementNum
                {"MarginAgreementNum", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(PLItem, new List<FieldBase>(){}),
							new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BusinessStrategy, new List<FieldBase>(){}),
							new CalcFieldInfo(MarginAgreementDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion MarginAgreementNum
						
				

				
				#region MarginAgreementDate
                {"MarginAgreementDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion MarginAgreementDate
						
				

				
				#region BusinessStrategy
                {"BusinessStrategy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BusinessStrategy
						
				

				
				#region PLItem
                {"PLItem", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Book, new List<FieldBase>(){}),
							new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion PLItem
						
				

				
				#region Book
                {"Book", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Branch, new List<FieldBase>(){}),
							new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion Book
						
				

				
				#region Branch
                {"Branch", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Customer, new List<FieldBase>(){}),
							new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion Branch
						
				

				
				#region Customer
                {"Customer", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(IsAgency, new List<FieldBase>(){}),
							new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion Customer
						
				

				
				#region IsAgency
                {"IsAgency", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(CostCenter, new List<FieldBase>(){}),
							new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion IsAgency
						
				

				
				#region CostCenter
                {"CostCenter", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Portfolio, new List<FieldBase>(){}),
							new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion CostCenter
						
				

				
				#region Portfolio
                {"Portfolio", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Netting, new List<FieldBase>(){}),
							new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion Portfolio
						
				

				
				#region Netting
                {"Netting", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(NotNetting, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion Netting
						
				

				
				#region NotNetting
                {"NotNetting", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(CustodianAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion NotNetting
						
				

				
				#region ClearingHouseAccount
                {"ClearingHouseAccount", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ClearingHouseAccount
						
				

				
				#region CustodianAccount
                {"CustodianAccount", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CustodianAccount
						
				

				
				#region ValueDate
                {"ValueDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
	
					}
				},
				#endregion ValueDate
						
				

				
				#region DaysToValue
                {"DaysToValue", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
	
					}
				},
				#endregion DaysToValue
						
				

				
				#region DeliveryDate
                {"DeliveryDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Broker, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
	
					}
				},
				#endregion DeliveryDate
						
				

				
				#region DaysToDelivery
                {"DaysToDelivery", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion DaysToDelivery
						
				

				
				#region Broker
                {"Broker", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(BrokerAgreement, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion Broker
						
				

				
				#region BrokerAgreement
                {"BrokerAgreement", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion BrokerAgreement
						
				

				
				#region ScaleList
                {"ScaleList", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion ScaleList
						
				

				
				#region BrokerComissionCcy
                {"BrokerComissionCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionPercentOfScale, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerCommissionDate, new List<FieldBase>(){}),
	
					}
				},
				#endregion BrokerComissionCcy
						
				

				
				#region BrokerCommissionDate
                {"BrokerCommissionDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerCommissionDate
						
				

				
				#region BrokerCommissionPercentOfScale
                {"BrokerCommissionPercentOfScale", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerCommissionPercentOfScale
						
				

				
				#region BrokerComissionConvRate
                {"BrokerComissionConvRate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion BrokerComissionConvRate
						
				

				
				#region BrokerComission
                {"BrokerComission", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion BrokerComission
						
				

				
				#region BrokerComissionPercent
                {"BrokerComissionPercent", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion BrokerComissionPercent
						
				

				
				#region BrokerComissionNumber
                {"BrokerComissionNumber", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(BrokerComissionSide, new List<FieldBase>(){}),
							new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion BrokerComissionNumber
						
				

				
				#region BrokerComissionSide
                {"BrokerComissionSide", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeFloorType, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingBasket, new List<FieldBase>(){}),
							new CalcFieldInfo(CounterpartyInfo, new List<FieldBase>(){}),
							new CalcFieldInfo(CommissionAccount, new List<FieldBase>(){}),
	
					}
				},
				#endregion BrokerComissionSide
						
				

				
				#region CommissionAccount
                {"CommissionAccount", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CommissionAccount
						
				

				
				#region CounterpartyInfo
                {"CounterpartyInfo", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion CounterpartyInfo
						
				

				
				#region AccountingBasket
                {"AccountingBasket", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion AccountingBasket
						
				

				
				#region TradeFloorType
                {"TradeFloorType", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion TradeFloorType
						
				

				
				#region EventsSchedule
                {"EventsSchedule", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(TradeMode, new List<FieldBase>(){}),
							new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
	
					}
				},
				#endregion EventsSchedule
						
				

				
				#region TradeMode
                {"TradeMode", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(EventEntryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EventTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Version, new List<FieldBase>(){}),
							new CalcFieldInfo(FOSystem, new List<FieldBase>(){}),
							new CalcFieldInfo(RegistrationDate, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusEventId, new List<FieldBase>(){}),
							new CalcFieldInfo(FocusTradeId, new List<FieldBase>(){}),
							new CalcFieldInfo(AccountingStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(BOParametersStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(RiskStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatusB, new List<FieldBase>(){}),
							new CalcFieldInfo(FoStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(Executive, new List<FieldBase>(){}),
							new CalcFieldInfo(EventStatus, new List<FieldBase>(){}),
							new CalcFieldInfo(OrderTime, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAuditInfo, new List<FieldBase>(){}),
	
					}
				},
				#endregion TradeMode
						
				

				
				#region TradeAuditInfo
                {"TradeAuditInfo", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion TradeAuditInfo
						
				

				
				#region Holidays
                {"Holidays", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Holidays
						
				

				
				#region OrderTime
                {"OrderTime", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion OrderTime
						
				

				
				#region EventStatus
                {"EventStatus", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion EventStatus
						
				

				
				#region Executive
                {"Executive", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Executive
						
				

				
				#region FoStatus
                {"FoStatus", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion FoStatus
						
				

				
				#region FoStatusB
                {"FoStatusB", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion FoStatusB
						
				

				
				#region RiskStatus
                {"RiskStatus", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion RiskStatus
						
				

				
				#region BOParametersStatus
                {"BOParametersStatus", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BOParametersStatus
						
				

				
				#region AccountingStatus
                {"AccountingStatus", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion AccountingStatus
						
				

				
				#region FocusTradeId
                {"FocusTradeId", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion FocusTradeId
						
				

				
				#region FocusEventId
                {"FocusEventId", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion FocusEventId
						
				

				
				#region RegistrationDate
                {"RegistrationDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion RegistrationDate
						
				

				
				#region FOSystem
                {"FOSystem", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion FOSystem
						
				

				
				#region Version
                {"Version", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Version
						
				

				
				#region EventTime
                {"EventTime", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion EventTime
						
				

				
				#region EventEntryDate
                {"EventEntryDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion EventEntryDate
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class SpotForwardPNote_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.SpotForwardPNote)Entity;

		public SpotForwardPNote_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (SpotForwardPNote)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(ClearingHouseAccount, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToValue, new List<FieldBase>(){}),
							new CalcFieldInfo(ValueDate, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(QtyItems, new List<FieldBase>(){}),
							new CalcFieldInfo(DeliveryDate, new List<FieldBase>(){}),
							new CalcFieldInfo(DealAmount, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCurrencyRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Payment, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteGroupsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionCommonCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionExchangeCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionClearingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionTradingSystemCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteAmount, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region ClearingHouseAccount
                {"ClearingHouseAccount", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ClearingHouseAccount
						
				

				
				#region ValueDate
                {"ValueDate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ValueDate
						
				

				
				#region DaysToValue
                {"DaysToValue", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion DaysToValue
						
				

				
				#region DeliveryDate
                {"DeliveryDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Holidays, new List<FieldBase>(){}),
							new CalcFieldInfo(QtyItems, new List<FieldBase>(){}),
							new CalcFieldInfo(DealAmount, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCurrencyRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Payment, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteGroupsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteAmount, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionClearingCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionCommonCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionTradingSystemCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ComissionExchangeCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionNumber, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionPercent, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComission, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionConvRate, new List<FieldBase>(){}),
							new CalcFieldInfo(BrokerComissionCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(ScaleList, new List<FieldBase>(){}),
							new CalcFieldInfo(DaysToDelivery, new List<FieldBase>(){}),
	
					}
				},
				#endregion DeliveryDate
						
				

				
				#region DaysToDelivery
                {"DaysToDelivery", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion DaysToDelivery
						
				

				
				#region ScaleList
                {"ScaleList", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ScaleList
						
				

				
				#region BrokerComissionCcy
                {"BrokerComissionCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionCcy
						
				

				
				#region BrokerComissionConvRate
                {"BrokerComissionConvRate", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionConvRate
						
				

				
				#region BrokerComission
                {"BrokerComission", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComission
						
				

				
				#region BrokerComissionPercent
                {"BrokerComissionPercent", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionPercent
						
				

				
				#region BrokerComissionNumber
                {"BrokerComissionNumber", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion BrokerComissionNumber
						
				

				
				#region ComissionExchangeCcy
                {"ComissionExchangeCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ComissionExchangeCcy
						
				

				
				#region ComissionTradingSystemCcy
                {"ComissionTradingSystemCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ComissionTradingSystemCcy
						
				

				
				#region ComissionCommonCcy
                {"ComissionCommonCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ComissionCommonCcy
						
				

				
				#region ComissionClearingCcy
                {"ComissionClearingCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion ComissionClearingCcy
						
				

				
				#region Holidays
                {"Holidays", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(QtyItems, new List<FieldBase>(){}),
							new CalcFieldInfo(DealAmount, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCurrencyRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Payment, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteGroupsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteAmount, new List<FieldBase>(){}),
	
					}
				},
				#endregion Holidays
						
				

				
				#region QtyItems
                {"QtyItems", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(DealAmount, new List<FieldBase>(){}),
							new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCurrencyRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Payment, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteGroupsSchedule, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteAmount, new List<FieldBase>(){}),
	
					}
				},
				#endregion QtyItems
						
				

				
				#region PNoteAmount
                {"PNoteAmount", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion PNoteAmount
						
				

				
				#region DealAmount
                {"DealAmount", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(PaymentCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(InstrCurrencyRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Payment, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteGroupsSchedule, new List<FieldBase>(){}),
	
					}
				},
				#endregion DealAmount
						
				

				
				#region PaymentCcy
                {"PaymentCcy", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(InstrCurrencyRate, new List<FieldBase>(){}),
							new CalcFieldInfo(Payment, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteGroupsSchedule, new List<FieldBase>(){}),
	
					}
				},
				#endregion PaymentCcy
						
				

				
				#region InstrCurrencyRate
                {"InstrCurrencyRate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Payment, new List<FieldBase>(){}),
							new CalcFieldInfo(PNoteGroupsSchedule, new List<FieldBase>(){}),
	
					}
				},
				#endregion InstrCurrencyRate
						
				

				
				#region Payment
                {"Payment", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(PNoteGroupsSchedule, new List<FieldBase>(){}),
	
					}
				},
				#endregion Payment
						
				

				
				#region PNoteGroupsSchedule
                {"PNoteGroupsSchedule", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion PNoteGroupsSchedule
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class SpotForwardPNoteImpl_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.SpotForwardPNoteImpl)Entity;

		public SpotForwardPNoteImpl_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (SpotForwardPNoteImpl)entity;
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
	
	public class DealGenericImpl_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.DealGenericImpl)Entity;

		public DealGenericImpl_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (DealGenericImpl)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(EventsSchedule, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region EventsSchedule
                {"EventsSchedule", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion EventsSchedule
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class SpotForwardBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.Deals.SpotForwardBase)Entity;

		public SpotForwardBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (SpotForwardBase)entity;
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
				
					}
				},
				#endregion input order
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class PNoteGroupGen_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.PNoteGroups.PNoteGroupGen)Entity;

		public PNoteGroupGen_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (PNoteGroupGen)entity;
		}
		
		#region define order

		protected Dictionary<string, List<CalcFieldInfo>> CreateCalcOrder()
		{
			var calcOrder = new Dictionary<string, List<CalcFieldInfo>>()
			{
							#region input order
                {"", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(InstrCcy, new List<FieldBase>(){}),
							new CalcFieldInfo(Issuer, new List<FieldBase>(){}),
							new CalcFieldInfo(TradeAmount, new List<FieldBase>(){}),
							new CalcFieldInfo(MaturityDate, new List<FieldBase>(){}),
							new CalcFieldInfo(IsInterest, new List<FieldBase>(){}),
							new CalcFieldInfo(Interest, new List<FieldBase>(){}),
							new CalcFieldInfo(StartInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EndInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(Nominal, new List<FieldBase>(){}),
							new CalcFieldInfo(RefPrice, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion input order
						
				

				
				#region Issuer
                {"Issuer", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion Issuer
						
				

				
				#region InstrCcy
                {"InstrCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion InstrCcy
						
				

				
				#region TradeAmount
                {"TradeAmount", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Nominal, new List<FieldBase>(){}),
							new CalcFieldInfo(MaturityDate, new List<FieldBase>(){}),
							new CalcFieldInfo(IsInterest, new List<FieldBase>(){}),
							new CalcFieldInfo(Interest, new List<FieldBase>(){}),
							new CalcFieldInfo(StartInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EndInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(RefPrice, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion TradeAmount
						
				

				
				#region Nominal
                {"Nominal", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(MaturityDate, new List<FieldBase>(){}),
							new CalcFieldInfo(IsInterest, new List<FieldBase>(){}),
							new CalcFieldInfo(Interest, new List<FieldBase>(){}),
							new CalcFieldInfo(StartInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EndInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(RefPrice, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion Nominal
						
				

				
				#region MaturityDate
                {"MaturityDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(IsInterest, new List<FieldBase>(){}),
							new CalcFieldInfo(Interest, new List<FieldBase>(){}),
							new CalcFieldInfo(StartInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EndInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(RefPrice, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion MaturityDate
						
				

				
				#region IsInterest
                {"IsInterest", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Interest, new List<FieldBase>(){}),
							new CalcFieldInfo(StartInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EndInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(RefPrice, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion IsInterest
						
				

				
				#region Interest
                {"Interest", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(StartInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(EndInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(RefPrice, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion Interest
						
				

				
				#region StartInterestDate
                {"StartInterestDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(EndInterestDate, new List<FieldBase>(){}),
							new CalcFieldInfo(RefPrice, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion StartInterestDate
						
				

				
				#region EndInterestDate
                {"EndInterestDate", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(RefPrice, new List<FieldBase>(){}),
							new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion EndInterestDate
						
				

				
				#region RefPrice
                {"RefPrice", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Price, new List<FieldBase>(){}),
							new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion RefPrice
						
				

				
				#region Price
                {"Price", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(Amount, new List<FieldBase>(){}),
							new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion Price
						
				

				
				#region Amount
                {"Amount", new List<CalcFieldInfo>()
					{
										new CalcFieldInfo(AmountPaymentCcy, new List<FieldBase>(){}),
	
					}
				},
				#endregion Amount
						
				

				
				#region AmountPaymentCcy
                {"AmountPaymentCcy", new List<CalcFieldInfo>()
					{
				
					}
				},
				#endregion AmountPaymentCcy
						
				

				
			
			};//new Dictionary
		 
			return calcOrder;
		}
	}
		#endregion //define order
	
	public class PNoteGroup_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.PNoteGroups.PNoteGroup)Entity;

		public PNoteGroup_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (PNoteGroup)entity;
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
	
	public class PNoteGroupBase_Graph : GraphBase
	{	
		(Egar.Focus.DealModule.PNoteGroups.PNoteGroupBase)Entity;

		public PNoteGroupBase_Graph(FieldsEntity entity/*, EntityExtentionBase extention*/) :base(entity/*, extention*/)
		{
			this.Entity= (PNoteGroupBase)entity;
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
}
