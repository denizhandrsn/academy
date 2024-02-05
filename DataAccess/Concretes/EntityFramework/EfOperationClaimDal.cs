using Core.DataAccess.EntityFramework;
using Core.Entities.Concretes;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfOperationClaimDal:EfEntityRepositoryBase<OperationClaim,BootCodeContext>,IOperationClaimDal
    {
    }
}
