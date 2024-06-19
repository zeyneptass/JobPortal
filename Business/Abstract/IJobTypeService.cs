using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobTypeService
    {
        IDataResult<List<JobType>> GetJobtypes();
        IDataResult<JobType> GetJobtypeById(int jobTypeId);
        IDataResult<List<JobType>> GetJobTypesByName(string jobType);
        IResult Add(JobType jobType);
        IResult Update(JobType jobType);
        IResult Delete(JobType jobType);
    }
}
