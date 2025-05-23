namespace UserInsightSurvey.Data.Abstract
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public DateTime Created { get; set; } = DateTime.Now;
		public DateTime? UpdatedDate { get; set; }
		public DateTime? Deleted {  get; set; } 
	}
}
