# What is it?

It is a .NET API wrapper for iTechArt SMG Portal.

# How to use:

* Create an API proxy
  ```c#
  SmgMobileServiceProxy api = new SmgMobileServiceProxy();
  ```

* Authentincate user:
  ```c#
  AuthenticateParameters authenticateParameters = new AuthenticateParameters
            {
                Password = password,
                UserName = userName
            };

  AuthenticateResult authResult = await api.Authenticate(authenticateParameters);
            
  if (authResult.ErrorCode.Equals(ErrorCode.None) && !String.IsNullOrEmpty(authResult.SesionId))
  {
      //TODO: authenticate user in the app                
  }
  ```
* Get a department's members:

  ```c#
  GetEmployeeDetailsListByDeptIdResult usersInDepartment =
      await api.GetEmployeeDetailsListByDeptId(new GetEmployeeDetailsListByDeptIdParameters
        {
          SessionId = SESSION_ID,
          DepartmentId = SMG_DEPARTMENT_ID
        }
      );
  ```
