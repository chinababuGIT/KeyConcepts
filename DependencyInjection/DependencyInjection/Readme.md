DependencyInjection (DI)
==========
### Concept
Dependency Injection (DI) is to promote loose coupling between classes. Widely used for constructing objects.
Say class A is composed of class B. Without DI, class will have to instantiate class B within its constructor.
This means that A has to have access to B during compile time. Any changes in B, we ave to recompile A with it.

Making B becomes an interface does not solve it either. It only lets you substitute other implemtation of the 
interface at coding, but in compilation, you are still tied to it when instance of B is created locally.
Remember compilation means all the address reference are resolved.

### Motivation

1. Updating the code by just dropping the changed dll very hard. All the old reference of address are now 
   invalid.

2. Makeing plugin architecture very hard. How can you substitute B to C by using config?
3. Unit testing. You can "mock up" the object to drive testing data
                                                                     
### Solution

1. Move construction of internal components outside of class A.
   2..Use construction injection. 
   2..Use setting injection  (allows expensive but not universally used resource to be created later)
1. Construction is no longer the control of A but move to the calling code that uses A :-Inversion of Control

### Pros 

1. 1 & 2 now possible. 

### Cons

1. slower because of 2 level of references. But only in construction time.
2. much harder to debug; you know the paing of those config filesand runtime error.


### Variation
1. Constructor Injection
1. Interface Injection
1. Service Locator
1. Setting Injection.

### Tidbits
 1. In Model View Controller. Controller do all these DI "Wiring"


