﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginPage
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Jan192019Entities : DbContext
    {
        public Jan192019Entities()
            : base("name=Jan192019Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetTaskdetails_Result> GetTaskdetails(string userName, string role)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var roleParameter = role != null ?
                new ObjectParameter("Role", role) :
                new ObjectParameter("Role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTaskdetails_Result>("GetTaskdetails", userNameParameter, roleParameter);
        }
    
        public virtual ObjectResult<string> InsertRegisterdetails(string lastname, string firstname, string userName, string password, string email, string role)
        {
            var lastnameParameter = lastname != null ?
                new ObjectParameter("Lastname", lastname) :
                new ObjectParameter("Lastname", typeof(string));
    
            var firstnameParameter = firstname != null ?
                new ObjectParameter("Firstname", firstname) :
                new ObjectParameter("Firstname", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var roleParameter = role != null ?
                new ObjectParameter("Role", role) :
                new ObjectParameter("Role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("InsertRegisterdetails", lastnameParameter, firstnameParameter, userNameParameter, passwordParameter, emailParameter, roleParameter);
        }
    
        public virtual ObjectResult<string> InsertTaskdetails(string userName, string taskDescription, Nullable<System.DateTime> taskDate, string taskST, string taskET)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var taskDescriptionParameter = taskDescription != null ?
                new ObjectParameter("TaskDescription", taskDescription) :
                new ObjectParameter("TaskDescription", typeof(string));
    
            var taskDateParameter = taskDate.HasValue ?
                new ObjectParameter("TaskDate", taskDate) :
                new ObjectParameter("TaskDate", typeof(System.DateTime));
    
            var taskSTParameter = taskST != null ?
                new ObjectParameter("TaskST", taskST) :
                new ObjectParameter("TaskST", typeof(string));
    
            var taskETParameter = taskET != null ?
                new ObjectParameter("TaskET", taskET) :
                new ObjectParameter("TaskET", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("InsertTaskdetails", userNameParameter, taskDescriptionParameter, taskDateParameter, taskSTParameter, taskETParameter);
        }
    
        public virtual ObjectResult<string> LoginCheck(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoginCheck", userNameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Loginlogoutdetails_Result> Loginlogoutdetails(string userName, string role)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var roleParameter = role != null ?
                new ObjectParameter("Role", role) :
                new ObjectParameter("Role", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Loginlogoutdetails_Result>("Loginlogoutdetails", userNameParameter, roleParameter);
        }
    
        public virtual int LoginoutdetailsInsert(string userName, Nullable<System.DateTime> loginTime, Nullable<System.DateTime> logoutime)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var loginTimeParameter = loginTime.HasValue ?
                new ObjectParameter("LoginTime", loginTime) :
                new ObjectParameter("LoginTime", typeof(System.DateTime));
    
            var logoutimeParameter = logoutime.HasValue ?
                new ObjectParameter("Logoutime", logoutime) :
                new ObjectParameter("Logoutime", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LoginoutdetailsInsert", userNameParameter, loginTimeParameter, logoutimeParameter);
        }
    }
}
