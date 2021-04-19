using System;

namespace efpostgres.Database.Exceptions
{
  public class EntityNotFoundException : Exception
  {
    public int RecordId { get; set; }
    public Type EntityType { get; set; }

    public EntityNotFoundException(int recordId, Type entityType)
      : base($"Requested entity  of type {entityType.Name} with primary key ID = {recordId} was not found in database")
    {
      RecordId = recordId;
      EntityType = entityType;
    }

    public EntityNotFoundException(Type entityType)
      : base($"Requested entity of type {entityType.Name} was not found in database")
    {
      RecordId = 0;
      EntityType = entityType;
    }

  }
}
