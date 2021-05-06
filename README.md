# Password Verifiers

This project was born to solve the problem of `passwords security level checking` and it's based on the business rule.

A valid password must pass in these criterias:

- Nine or more characters 
- At least 1 digit
- At least 1 lower character
- At least 1 upper character
- At least 1 special character which must to be `!@#$%^&*()-+`
- It can't contains repeated characters
- It can't contains empty spaces

Click [here](https://github.com/itidigital/backend-challenge) to see more details about the specifications.

### Design 

This project was designed to follow the principles of [DDD](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/ddd-oriented-microservice)
which is responsible to advocates modeling based on the reality of business as relevant to your use cases. In the context of building applications, DDD talks about problems as domains.

![VerifiersDesign](https://i.ibb.co/qydCkRy/Password-Verifiers.png)

### Design Patterns

In this project we needed to use the pattern [Chain Of Responsibility](https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern) to make sure that passwords are valid and respecting the business rules. You could check 
[here](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordValueObject.cs) the use of the pattern. Also it was divided into value objects containing the password assert rules, which are:

- [PasswordCharQuantityValueObject](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordCharQuantityValueObject.cs)
- [PasswordContainsDigitValueObject](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordContainsDigitValueObject.cs)
- [PasswordContainsDistinctValueObject](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordContainsDistinctValueObject.cs)
- [PasswordContainsEmptyValueObject](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordContainsEmptyValueObject.cs)
- [PasswordContainsLowerValueObject](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordContainsLowerValueObject.cs)
- [PasswordContainsSpecialValueObject](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordContainsSpecialValueObject.cs)
- [PasswordContainsUpperValueObject](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordContainsUpperValueObject.cs)
- [PasswordValueObject](https://github.com/anzileiro/verifiers/blob/main/Verifiers.Domain/ValueObjects/PasswordValueObject.cs)


### How to run and test it

- Clone: 
  
  ```terminal
    git clone git@github.com:anzileiro/verifiers.git
  ```

- Run:

  ```terminal 
    dotnet run --project Verifiers.Web/Verifiers.Web.csproj
    
    curl -X GET "https://localhost:5001/v1/Verifiers/passwords/abcdefghkl1@P"
  ````
  
  Also you could access and test from web:
  
  https://localhost:5001/swagger/index.html
  
- Test:

  ```terminal
    dotnet test
  ```
