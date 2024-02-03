using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;

namespace Shared.Models
{
    public abstract class BaseDto<TDto, TEntity> : IRegister
        where TDto : class, new()
        where TEntity : class, new()
    {
        public long Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;

        public TEntity ToEntity()
        {
            return this.Adapt<TEntity>();
        }

        public TEntity ToEntity(TEntity entity)
        {
            return (this as TDto).Adapt(entity);
        }

        public static TDto FromEntity(TEntity entity)
        {
            return entity.Adapt<TDto>();
        }


        private TypeAdapterConfig Config { get; set; }

        public virtual void AddCustomMappings()
        {

        }


        protected TypeAdapterSetter<TDto, TEntity> SetCustomMappings()

            => Config.ForType<TDto, TEntity>();

        protected TypeAdapterSetter<TEntity, TDto> SetCustomMappingsInverse()

            => Config.ForType<TEntity, TDto>();

        public void Register(TypeAdapterConfig config)
        {
            Config = config;
            AddCustomMappings();
        }
    }
}
