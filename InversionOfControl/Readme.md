IOC 
==========
### Concept
Normal flow of Control: the class that is containing other class(Composition relationship). The "container" class
will do all the instantiation. Constructor calling a bunch of "new". Client using the container class just sit and wait
has no control of how the container class does its own construction.

Inversion of Control: the container class no longer do any of these "newing". Instead the client now determine 
how the container class is constructed. This is where the "inverstion" comes from.

### Code 
See Dependency Injection IOC Container for details