# Single-Linked-List

<h3>❓What is Linked List❓</h3>
Like arrays, Linked List is a linear data structure. Unlike arrays, linked list elements are not stored
at a contiguous location; the elements are linked using pointers. They include a series of connected nodes. Here, 
each node stores the data and the address of the next node.


![LLdrawio](https://user-images.githubusercontent.com/86704802/190682690-6fda5cff-63a5-45fa-a2cc-4fd84d275846.png)

<h3>❓Why Linked List❓</h3>
1-) 🤔The size of the arrays is fixed: So we must know the upper limit on the number of elements in advance.
Also, generally, the allocated memory is equal to the upper limit irrespective of the usage.

2-) Insertion of a new element / Deletion of a existing element in an array of elements is expensive:
The room has to be created for the new elements and to create room existing elements have to be shifted
but in Linked list if we have the head node then we can traverse to any node through it and insert 
new node at the required position.

<h3>💡Advantages of Linked Lists💡</h3>
-Dynamic Array.

-Ease of Insertion/Deletion.

<h3>✨Linked Lists Summary✨</h3>
A linked list is represented by a pointer to the first node of the linked list. The first node is called the head of the linked list. If the linked list is empty, then the value of the head points to NULL. 

Each node in a list consists of at least two parts: 

-A Data Item (we can store integer, strings, or any type of data).

-Pointer (Or Reference) to the next node (connects one node to another) or An address of another node
