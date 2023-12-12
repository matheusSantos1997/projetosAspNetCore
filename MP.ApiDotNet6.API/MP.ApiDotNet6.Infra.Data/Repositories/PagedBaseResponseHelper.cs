using Microsoft.EntityFrameworkCore;
using MP.ApiDotNet6.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Infra.Data.Repositories
{
    public static class PagedBaseResponseHelper
    {
        public static async Task<TResponse> GetResponseAsync<TResponse, T>
            (IQueryable<T> query, PagedBaseRequest request)
            where TResponse : PageBaseResponse<T>, new()
        {
            var response = new TResponse();
            var count = await query.CountAsync();
            response.TotalPages = (int)Math.Abs((double)count / request.PageSize);
            response.TotalRegisters = count;
            if(string.IsNullOrEmpty(request.OrderByProperty))
                response.Data = await query.ToListAsync();
            else
                response.Data = query.OrderByDynamic(request.OrderByProperty)
                                     .Skip((request.Page - 1) * request.PageSize)
                                     .Take(request.PageSize)
                                     .ToList();

            return response;
        }

        private static IEnumerable<T> OrderByDynamic<T>(this IEnumerable<T> query, string propertyName)
        {
            return query.OrderBy(x => x.GetType().GetProperty(propertyName).GetValue(x, null));
        }

    }
}
