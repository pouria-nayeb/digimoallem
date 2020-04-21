using DigiMoallem.BLL.DTOs.General;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<MessageService> _logger;

        public MessageService(ApplicationDbContext context, ILogger<MessageService> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Add new Messages to database.
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        #region Add Messages
        public Contact AddContact(Contact contact)
        {
            try
            {
                _context.Messages.Add(contact);
                _context.SaveChanges();

                return contact;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public async Task<Contact> AddContactAsync(Contact contact)
        {
            try
            {
                await _context.Messages.AddAsync(contact);
                await _context.SaveChangesAsync();

                return contact;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }
        #endregion

        /// <summary>
        /// Get all Messages.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        #region Get Messages
        public ContactPagingViewModel GetContacts(int pageNumber = 1, int pageSize = 24)
        {
            IQueryable<Contact> Messages = _context.Messages;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int MessagesCount = Messages.Count();

            int pageCount = (int)Math.Ceiling(Decimal.Divide(MessagesCount, take));

            return new ContactPagingViewModel
            {
                Contacts = Messages.Skip(skip).Take(take)
                .OrderByDescending(c => c.ContactId)
                .ToList(),
                PageNumber = pageNumber,
                PageCount = pageCount
            };
        }

        public async Task<ContactPagingViewModel> GetContactsAsync(int pageNumber = 1, int pageSize = 24)
        {
            IQueryable<Contact> Messages = _context.Messages;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int MessagesCount = Messages.Count();

            int pageCount = (int)Math.Ceiling(Decimal.Divide(MessagesCount, take));

            return new ContactPagingViewModel
            {
                Contacts = await Messages.Skip(skip).Take(take)
                .OrderByDescending(c => c.ContactId)
                .ToListAsync(),
                PageNumber = pageNumber,
                PageCount = pageCount
            };
        }
        #endregion

        /// <summary>
        /// Get contact by id from database.
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        #region Get contact by id
        public Contact GetContactById(int contactId) => _context.Messages.Find(contactId);

        public async Task<Contact> GetContactByIdAsync(int contactId) => await _context.Messages
            .FindAsync(contactId);
        #endregion

        /// <summary>
        /// Update the contact's data from database.
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        #region Update contact
        public Contact UpdateContact(Contact contact)
        {
            try
            {
                _context.Messages.Update(contact);
                _context.SaveChanges();

                return contact;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }

        public async Task<Contact> UpdateContactAsync(Contact contact)
        {
            try
            {
                _context.Messages.Update(contact);
                await _context.SaveChangesAsync();

                return contact;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }
        #endregion

        /// <summary>
        /// Remove the contact from database.
        /// </summary>
        /// <param name="contactId"></param>
        #region Remove contact
        public void RemoveContact(int contactId)
        {
            var contact = GetContactById(contactId);

            _context.Messages.Remove(contact);
            _context.SaveChanges();
        }

        public async Task RemoveContactAsync(int contactId)
        {
            var contact = await GetContactByIdAsync(contactId);

            _context.Messages.Remove(contact);
            await _context.SaveChangesAsync();
        }
        #endregion

        /// <summary>
        /// Search Messages based on phoneNumber.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        #region Search Messages
        public List<Contact> SearchContacts(string phoneNumber) => _context.Messages
            .Where(c => c.PhoneNumber.Contains(phoneNumber))
            .ToList();

        public async Task<List<Contact>> SearchContactsAsync(string phoneNumber) => await _context.Messages
            .Where(c => c.PhoneNumber.Contains(phoneNumber))
            .ToListAsync();
        #endregion

        /// <summary>
        /// Messages count.
        /// </summary>
        /// <returns></returns>
        #region Messages count
        public int ContactsCount() => _context.Messages.Count();
        public async Task<int> ContactsCountAsync() => await _context.Messages.CountAsync();
        #endregion

        /// <summary>
        /// New Messages count
        /// </summary>
        /// <returns></returns>
        #region New Messages count
        public int NewContactsCount() => _context.Messages.Where(c => c.IsChecked == false).Count();

        public async Task<int> NewContactsCountAsync() => await _context.Messages
            .Where(c => c.IsChecked == false)
            .CountAsync();
        #endregion
    }
}
