﻿// -----------------------------------------------------------------------
//  <copyright file="ILifetimeHub.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2016 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2016-04-02 14:11</last-date>
// -----------------------------------------------------------------------

using System;
using System.Threading.Tasks;

using Microsoft.AspNet.SignalR.Hubs;


namespace OSharp.Autofac.SignalR
{
    /// <summary>
    /// 带生命周期作用域的Hub
    /// </summary>
    public interface ILifetimeHub : IHub
    {
        /// <summary>
        /// 加入当前集线器的组
        /// </summary>
        /// <param name="groupName">组名称</param>
        /// <returns></returns>
        Task JoinGroup(string groupName);

        /// <summary>
        /// 离开当前集线器的组
        /// </summary>
        /// <param name="groupName">组名称</param>
        /// <returns></returns>
        Task LeaveGroup(string groupName);

        /// <summary>
        /// 对象释放事件
        /// </summary>
        event EventHandler OnDisposing;
    }
}