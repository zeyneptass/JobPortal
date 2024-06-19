using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class JobTypeManager : IJobTypeService
    {
        IJobTypeDal _jobTypeDal;

        public JobTypeManager(IJobTypeDal jobTypeDal)
        {
            _jobTypeDal = jobTypeDal;
        }
        public IResult Add(JobType jobType)
        {
            _jobTypeDal.Add(jobType);
            return new SuccessResult(Messages.JobTypeAdd);
        }

        public IResult Delete(JobType jobType)
        {
            _jobTypeDal.Delete(jobType);
            return new SuccessResult(Messages.JobTypeDeleted);
        }

        public IDataResult<JobType> GetJobtypeById(int jobTypeId)
        {
            return new SuccessDataResult<JobType>(_jobTypeDal.Get(u=> u.JobTypeId == jobTypeId));
        }

        public IDataResult<List<JobType>> GetJobtypes()
        {
            return new SuccessDataResult<List<JobType>>(_jobTypeDal.GetAll(),Messages.JobTypeListed);
        }

        public IDataResult<List<JobType>> GetJobTypesByName(string jobType)
        {

            var job = _jobTypeDal.Get(j => j.JobStyle == jobType);
            if (job != null)
            {
                return new SuccessDataResult<List<JobType>>(jobType);
            }
            return new ErrorDataResult<List<JobType>>();
        }

        public IResult Update(JobType jobType)
        {
            _jobTypeDal.Update(jobType);    
            return new SuccessResult(Messages.JobTypeUpdated);
        }
    }
}
