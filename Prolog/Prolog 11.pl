man(alex).
man(max).
man(denis).
man(dima).
man(kirill).
man(egor).
man(oleg).
man(petr).
woman(oly).
woman(maha).
woman(katy).
woman(any).
woman(yna).
woman(ksyha).
parent(oly,maha).
parent(oly,max).
parent(alex,maha).
parent(alex,max).

parent(max,denis).
parent(any,denis).

parent(dima,any).
parent(dima,yna).
parent(katy,any).
parent(katy,yna).

parent(yna,kirill).
parent(yna,egor).
parent(oleg,kirill).
parent(oleg,egor).

parent(ksyha,oleg).
parent(petr,oleg).

father(X,Y):-man(X),parent(X,Y).
father(X):-father(Y,X),write(Y).