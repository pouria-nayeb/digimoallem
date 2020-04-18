using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.Permissions;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly ApplicationDbContext _db;

        public PermissionService(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Get all roles
        /// </summary>
        #region Get roles
        public List<Role> GetRoles()
        {
            return _db.Roles.ToList();
        }
        public async Task<List<Role>> GetRolesAsync()
        {
            return await _db.Roles.ToListAsync();
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roleIds"></param>
        /// <param name="userId"></param>
        #region AssignRolesToUser
        public bool AssignRolesToUser(List<int> roleIds, int userId)
        {
            try
            {
                // db success
                foreach (var roleId in roleIds)
                {
                    _db.UserInRoles.Add(new UserInRole()
                    {
                        UserId = userId,
                        RoleId = roleId
                    });
                }

                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        public async Task<bool> AssignRolesToUserAsync(List<int> roleIds, int userId)
        {
            try
            {
                // db success
                foreach (var roleId in roleIds)
                {
                    await _db.UserInRoles.AddAsync(new UserInRole()
                    {
                        UserId = userId,
                        RoleId = roleId
                    });
                }

                await SaveAsync();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Edit roles assigned
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleIds"></param>
        #region EditRolesAssigned
        public bool EditRolesAssigned(int userId, List<int> roleIds)
        {
            try
            {
                // delete user old roles
                _db.UserInRoles.Where(r => r.UserId == userId).ToList()
                    .ForEach(u => _db.UserInRoles.Remove(u));

                // assign new roles to user
                AssignRolesToUser(roleIds, userId);

                return true;
            }
            catch
            {
                // TODO: log error
                return false;
            }
        }
        public async Task<bool> EditRolesAssignedAsync(int userId, List<int> roleIds)
        {
            try
            {
                // delete user old roles
                _db.UserInRoles.Where(r => r.UserId == userId).ToList()
                     .ForEach(u => _db.UserInRoles.Remove(u));

                // assign new roles to user
                await AssignRolesToUserAsync(roleIds, userId);

                return true;
            }
            catch
            {
                // TODO: log error
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Add new role
        /// </summary>
        /// <param name="role"></param>
        #region AddRole
        public int AddRole(Role role)
        {
            try
            {
                // db success
                _db.Roles.Add(role);
                Save();

                return role.RoleId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        public async Task<int> AddRoleAsync(Role role)
        {
            try
            {
                // db success
                await _db.Roles.AddAsync(role);
                await SaveAsync();

                return role.RoleId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        #endregion

        /// <summary>
        /// Get role by id
        /// </summary>
        /// <param name="roleId"></param>
        #region GetRoleById
        public Role GetRoleById(int roleId)
        {
            return _db.Roles.SingleOrDefault(r => r.RoleId == roleId);
        }

        public async Task<Role> GetRoleByIdAsync(int roleId)
        {
            return await _db.Roles.SingleOrDefaultAsync(r => r.RoleId == roleId);
        }
        #endregion

        /// <summary>
        /// Update role
        /// </summary>
        /// <param name="role"></param>
        #region UpdateRole
        public bool UpdateRole(Role role)
        {
            try
            {
                // db success
                _db.Roles.Update(role);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> UpdateRoleAsync(Role role)
        {
            try
            {
                // db success
                _db.Roles.Update(role);
                await SaveAsync();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Delete role
        /// </summary>
        /// <param name="roleId"></param>
        #region DeleteRole
        public bool DeleteRole(Role role)
        {
            role.IsDelete = true;

            return UpdateRole(role);
        }

        public async Task<bool> DeleteRoleAsync(Role role)
        {
            role.IsDelete = true;

            return await UpdateRoleAsync(role);
        }
        #endregion

        /// <summary>
        /// Get all permissions
        /// </summary>
        #region GetAllPermissions
        public List<Permission> GetAllPermissions()
        {
            return _db.Permissions.ToList();
        }

        public async Task<List<Permission>> GetAllPermissionsAsync()
        {
            return await _db.Permissions.ToListAsync();
        }
        #endregion

        /// <summary>
        /// Assign permissions to role
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="permissions"></param>
        #region AddPermission
        public bool AddPermissionsToRole(int roleId, List<int> permissions)
        {
            try
            {
                // db success
                foreach (var permissionId in permissions)
                {
                    _db.PermissionsInRole.Add(new PermissionsInRole()
                    {
                        RoleId = roleId,
                        PermissionId = permissionId
                    });
                }
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> AddPermissionsToRoleAsync(int roleId, List<int> permissions)
        {
            try
            {
                // db success
                foreach (var permissionId in permissions)
                {
                    await _db.PermissionsInRole.AddAsync(new PermissionsInRole()
                    {
                        RoleId = roleId,
                        PermissionId = permissionId
                    });
                }
                await SaveAsync();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Get permissions assigned to users
        /// </summary>
        /// <param name="roleId"></param>
        #region GetPermissionsOfRole
        public List<int> GetPermissionsOfRole(int roleId)
        {
            return _db.PermissionsInRole
                .Where(pr => pr.RoleId == roleId)
                .Select(pr => pr.PermissionId)
                .ToList();
        }

        public async Task<List<int>> GetPermissionsOfRoleAsync(int roleId)
        {
            return await _db.PermissionsInRole
                .Where(pr => pr.RoleId == roleId)
                .Select(pr => pr.PermissionId)
                .ToListAsync();
        }
        #endregion

        /// <summary>
        /// Update permissions of role
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="permissions"></param>
        #region UpdatePermissionsOfRole
        public bool UpdatePermissionsOfRole(int roleId, List<int> permissions)
        {
            try
            {
                // db success
                _db.PermissionsInRole.Where(pr => pr.RoleId == roleId)
                    .ToList().ForEach(pr => _db.PermissionsInRole.Remove(pr));

                AddPermissionsToRole(roleId, permissions);

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> UpdatePermissionsOfRoleAsync(int roleId, List<int> permissions)
        {
            try
            {
                // db success
                _db.PermissionsInRole.Where(pr => pr.RoleId == roleId)
                    .ToList().ForEach(pr => _db.PermissionsInRole.Remove(pr));

                await AddPermissionsToRoleAsync(roleId, permissions);

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Get permission names of a role
        /// </summary>
        /// <param name="roleId"></param>
        #region GetPermissionNamesOfRole
        public List<Permission> GetPermissionNamesOfRole(int roleId)
        {
            return _db.PermissionsInRole
                .Include(p => p.Permission)
                .Where(pr => pr.RoleId == roleId)
                .Select(pr => pr.Permission)
                .ToList();
        }

        public async Task<List<Permission>> GetPermissionNamesOfRoleAsync(int roleId)
        {
            return await _db.PermissionsInRole
                .Include(p => p.Permission)
                .Where(pr => pr.RoleId == roleId)
                .Select(pr => pr.Permission)
                .ToListAsync();
        }
        #endregion

        /// <summary>
        /// Check user permissions and accessibilities
        /// </summary>
        /// <param name="permissionId"></param>
        /// <param name="userName"></param>
        #region CheckPermission
        public bool CheckPermission(int permissionId, string userName)
        {
            var userId = _db.Users.SingleOrDefault(u => u.UserName == userName).UserId;
            List<int> userRoles = _db.UserInRoles
                .Where(ur => ur.UserId == userId)
                .Select(ur => ur.RoleId)
                .ToList();

            if (!userRoles.Any())
            {
                return false;
            }

            List<int> rolePermissions = _db.PermissionsInRole
                .Where(pr => pr.PermissionId == permissionId)
                .Select(pr => pr.RoleId)
                .ToList();

            return rolePermissions.Any(pr => userRoles.Contains(pr));
        }

        public async Task<bool> CheckPermissionAsync(int permissionId, string userName)
        {
            var user = await _db.Users.SingleOrDefaultAsync(u => u.UserName == userName);
            var userId = user.UserId;
            List<int> userRoles = await _db.UserInRoles
                .Where(ur => ur.UserId == userId)
                .Select(ur => ur.RoleId)
                .ToListAsync();

            if (!userRoles.Any())
            {
                return false;
            }

            List<int> rolePermissions = await _db.PermissionsInRole
                .Where(pr => pr.PermissionId == permissionId)
                .Select(pr => pr.RoleId)
                .ToListAsync();

            return rolePermissions.Any(pr => userRoles.Contains(pr));
        }
        #endregion

        #region Save
        public void Save()
        {
            _db.SaveChanges();
        }
        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
        #endregion
    }
}
