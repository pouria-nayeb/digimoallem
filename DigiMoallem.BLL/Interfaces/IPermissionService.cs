using DigiMoallem.DAL.Entities.Permissions;
using DigiMoallem.DAL.Entities.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IPermissionService : IDisposable
    {
        // role admin
        #region Get roles
        List<Role> GetRoles();
        Task<List<Role>> GetRolesAsync();
        #endregion

        #region AssignRolesToUser
        bool AssignRolesToUser(List<int> roleIds, int userId);
        Task<bool> AssignRolesToUserAsync(List<int> roleIds, int userId);
        #endregion

        #region EditRolesAssigned
        bool EditRolesAssigned(int userId, List<int> roleIds);
        Task<bool> EditRolesAssignedAsync(int userId, List<int> roleIds);
        #endregion

        #region AddRole
        int AddRole(Role role);
        Task<int> AddRoleAsync(Role role);
        #endregion

        #region GetRoleById
        Role GetRoleById(int roleId);
        Task<Role> GetRoleByIdAsync(int roleId);
        #endregion

        #region UpdateRole
        bool UpdateRole(Role role);
        Task<bool> UpdateRoleAsync(Role role);
        #endregion

        #region DeleteRole
        bool DeleteRole(Role role);
        Task<bool> DeleteRoleAsync(Role role);
        #endregion

        // Permissions
        #region GetAllPermissions
        List<Permission> GetAllPermissions();
        Task<List<Permission>> GetAllPermissionsAsync();
        #endregion

        #region AddPermission
        bool AddPermissionsToRole(int roleId, List<int> permissions);
        Task<bool> AddPermissionsToRoleAsync(int roleId, List<int> permissions);
        #endregion

        #region GetPermissionsOfRole
        List<int> GetPermissionsOfRole(int roleId);
        Task<List<int>> GetPermissionsOfRoleAsync(int roleId);
        #endregion

        #region UpdatePermissionsOfRole
        bool UpdatePermissionsOfRole(int roleId, List<int> permissions);
        Task<bool> UpdatePermissionsOfRoleAsync(int roleId, List<int> permissions);
        #endregion

        #region GetPermissionNamesOfRole
        List<Permission> GetPermissionNamesOfRole(int roleId);
        Task<List<Permission>> GetPermissionNamesOfRoleAsync(int roleId);
        #endregion

        #region CheckPermission
        bool CheckPermission(int permissionId, string userName);
        Task<bool> CheckPermissionAsync(int permissionId, string userName);
        #endregion

        #region Save
        void Save();
        Task SaveAsync();
        #endregion
    }
}
