using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;

namespace Onguard.TimeTracker.DAL
{
    /// <summary>
    /// Interface for the VSTS Api
    /// </summary>
    public interface IVstsApi
    {
        /// <summary>
        /// Get all projects
        /// </summary>
        /// <returns>Collection of project names</returns>
        Task<IEnumerable<ProjectModel>> GetProjects();

        /// <summary>
        /// Get work items for given sprint within a project
        /// </summary>
        /// <returns>Collection of work items</returns>
        Task<IEnumerable<WorkItem>> GetReport(string project, string team, string sprint);

        /// <summary>
        /// Get work items between given dates within a project
        /// </summary>
        /// <returns>Collection of work items</returns>
        Task<IEnumerable<WorkItem>> GetReport(string project, string team, DateTime startDate, DateTime endDate, string tag, bool includePbis, bool includeDefects);

        Task<List<WorkItem>> GetWorkItems(IEnumerable<int> ids);

        Task<ListofRevisionsReponse.Revisions> GetWorkItemRevisions(int workItemId);
    }
}