
--插入一个角色组到表SysRole
INSERT INTO [SysRole] ([Id],[Name],[Description],[CreateTime],[CreatePerson]) values ('administrator',N'超级管理员',N'全部授权','2017-10-1','Administrator')


--将模块授权给SysRight
INSERT INTO [SysRight] ([Id],[ModuleId],[RoleId],[Rightflag]) values ('administratorSampleFile','SampleFile','administrator',1)
INSERT INTO [SysRight] ([Id],[ModuleId],[RoleId],[Rightflag]) values ('administratorBaseSample','BaseSample','administrator',1)


--把权限赋给角色SysRightOperate
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleCreate','administratorBaseSample','Create',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleDelete','administratorBaseSample','Delete',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleDetails','administratorBaseSample','Details',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleEdit','administratorBaseSample','Edit',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleExport','administratorBaseSample','Export',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleQuery','administratorBaseSample','Query',1)
INSERT INTO [SysRightOperate] ([Id],[RightId],[KeyCode],[IsValid]) values ('administratorBaseSampleSave','administratorBaseSample','Save',1)


--创建一个用户SysUser
INSERT INTO [SysUser] ([Id],[UserName],[Password],[TrueName],[Card],[MobileNumber],[PhoneNumber],[QQ],[EmailAddress],[OtherContact],[Province],[City],[Village],[Address],[State],[CreateTime],[CreatePerson],[Sex],[Birthday],[JoinDate],[Marital],[Political],[Nationality],[Native],[School],[Professional],[Degree],[DepId],[PosId],[Expertise],[JobState],[Photo],[Attach]) 
values ('admin','admin','01-92-02-3A-7B-BD-73-25-05-16-F0-69-DF-18-B5-00',N'系统管理员',NULL,NULL,'06638888888','324345345','xxx@xxx.com','MSN：xxx','440000','440100','440101',N'小小村落',1,'2017-10-1','admin',N'男','1990-1-1','2017-1-1',N'未婚',N'中国',N'中国',N'江苏',N'美国哈佛大学',N'计算机工程',N'硕士','20000','20001',N'勤劳向学,为人友善,乐于助人',N'在职',NULL,NULL)



--把角色分配给用户 SysRoleSysUser
INSERT INTO [SysRoleSysUser] ([SysUserId],[SysRoleId]) values ('admin','administrator')