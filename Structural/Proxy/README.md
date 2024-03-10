# Proxy Pattern
The Proxy design pattern is a structural pattern that provides a surrogate or placeholder for another object to control access to it. This surrogate, known as the proxy, can add functionalities such as lazy loading, access control, logging, or monitoring without altering the core logic of the real subject.

Here are the main components of the Proxy pattern:

Subject Interface (Subject): Declares the common interface for both RealSubject and Proxy so that the Proxy can be used wherever the RealSubject is expected.
RealSubject: Represents the real object that the Proxy represents. This is the object that the client wants to access.
Proxy: Maintains a reference to the RealSubject and implements the same interface as the RealSubject. The proxy controls access to the real object and may perform additional tasks before or after forwarding the request.
Client: Interacts with the Proxy, treating it as if it were a RealSubject.
