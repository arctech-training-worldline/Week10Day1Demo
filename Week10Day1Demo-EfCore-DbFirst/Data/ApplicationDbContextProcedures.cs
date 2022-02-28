﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Week10Day1Demo_EfCore_DbFirst.Models;

namespace Week10Day1Demo_EfCore_DbFirst.Data
{
    public partial class ApplicationDbContext
    {
        private ApplicationDbContextProcedures _procedures;

        public virtual ApplicationDbContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new ApplicationDbContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public ApplicationDbContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddOrderResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<DeleteOrderResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<DeleteStudentResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<EditOrderResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<GetIdResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<GetStudentByRollNoResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<InsertStudentResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<UpdateStudentResult>().HasNoKey().ToView(null);
        }
    }

    public interface IApplicationDbContextProceduresContract
    {
        Task<int> AddOrderAsync(int? Id, string Title, DateTime? Date, double? StateTax, CancellationToken cancellationToken = default);
        Task<int> DeleteOrderAsync(int? Id, CancellationToken cancellationToken = default);
        Task<int> DeleteStudentAsync(int? RollNo, CancellationToken cancellationToken = default);
        Task<int> EditOrderAsync(int? Id, string Title, DateTime? Date, double? StateTax, CancellationToken cancellationToken = default);
        Task<List<GetIdResult>> GetIdAsync(int? Id, CancellationToken cancellationToken = default);
        Task<List<GetStudentByRollNoResult>> GetStudentByRollNoAsync(int? RollNo, CancellationToken cancellationToken = default);
        Task<int> InsertStudentAsync(int? RollNo, string Name, DateTime? DateOfBirth, double? Percentage, CancellationToken cancellationToken = default);
        Task<int> UpdateStudentAsync(int? RollNo, string Name, DateTime? DateOfBirth, double? Percentage, CancellationToken cancellationToken = default);
    }

    public partial class ApplicationDbContextProcedures
    {
        private readonly ApplicationDbContext _context;

        public ApplicationDbContextProcedures(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual async Task<int> AddOrderAsync(int? Id, string Title, DateTime? Date, double? StateTax, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "Id",
                    Value = Id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "Title",
                    Size = 100,
                    Value = Title ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Date",
                    Value = Date ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                new SqlParameter
                {
                    ParameterName = "StateTax",
                    Value = StateTax ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Float,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[AddOrder] @Id, @Title, @Date, @StateTax", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> DeleteOrderAsync(int? Id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "Id",
                    Value = Id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[DeleteOrder] @Id", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> DeleteStudentAsync(int? RollNo, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "RollNo",
                    Value = RollNo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[DeleteStudent] @RollNo", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> EditOrderAsync(int? Id, string Title, DateTime? Date, double? StateTax, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "Id",
                    Value = Id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "Title",
                    Size = 100,
                    Value = Title ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "Date",
                    Value = Date ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.DateTime,
                },
                new SqlParameter
                {
                    ParameterName = "StateTax",
                    Value = StateTax ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Float,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[EditOrder] @Id, @Title, @Date, @StateTax", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<GetIdResult>> GetIdAsync(int? Id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "Id",
                    Value = Id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GetIdResult>("EXEC @returnValue = [dbo].[GetId] @Id", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<GetStudentByRollNoResult>> GetStudentByRollNoAsync(int? RollNo, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "RollNo",
                    Value = RollNo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GetStudentByRollNoResult>("EXEC @returnValue = [dbo].[GetStudentByRollNo] @RollNo", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> InsertStudentAsync(int? RollNo, string Name, DateTime? DateOfBirth, double? Percentage, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "RollNo",
                    Value = RollNo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "Name",
                    Size = 100,
                    Value = Name ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "DateOfBirth",
                    Value = DateOfBirth ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Date,
                },
                new SqlParameter
                {
                    ParameterName = "Percentage",
                    Value = Percentage ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Float,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[InsertStudent] @RollNo, @Name, @DateOfBirth, @Percentage", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> UpdateStudentAsync(int? RollNo, string Name, DateTime? DateOfBirth, double? Percentage, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "RollNo",
                    Value = RollNo ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "Name",
                    Size = 100,
                    Value = Name ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "DateOfBirth",
                    Value = DateOfBirth ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Date,
                },
                new SqlParameter
                {
                    ParameterName = "Percentage",
                    Value = Percentage ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Float,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[UpdateStudent] @RollNo, @Name, @DateOfBirth, @Percentage", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}