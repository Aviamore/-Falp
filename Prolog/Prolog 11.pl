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

%11 zadaniye
father(X,Y):-man(X),parent(X,Y).
father(X):-father(Y,X),write(Y).

%12 zadaniye
wire(X,Y):-woman(X),man(Y),parent(X,G),parent(Y,G).
wife(X):-wire(Y,X),write(Y).

%13 zadaniye
grand_ma(X, Y):-woman(X),parent(X,Z),parent(Z,Y),!.
grand_mas(X):-grand_ma(X,Y),write(X),nl.

%14 zadaniye
grand_ma_and_son(X,Y):-grand_ma(X,Y),man(Y),!;man(X),grand_ma(Y,X),!.

 %15 zadaniye
proiz_cifr(X,Y):-X<10, Y is X mod 10, !.
proiz_cifr(X,Y):-X>=10, X1 is X div 10, proiz_cifr(X1,P), Y is (X mod 10)*P,!.

%16 zadaniye
down_proiz_cifr(X,Y,Res):-X<10, Y1 is Y*(X mod 10), Res is Y1,write(Res),!.
down_proiz_cifr(X,Y,Res):-X>=10, X1 is X div 10, Y1 is Y*(X mod 10),down_proiz_cifr(X1,Y1,Res),!.
down_mult(X):-down_proiz_cifr(X,1,Res),!.

%17 zadaniye
max_not_div3(0,-1):-!.
max_not_div3(X,Y):-X1 is X div 10, max_not_div3(X1, C1),
    C2 is X mod 10, (C2>C1, C2 mod 3 =\= 0, Y is C2; Y is C1).

%18 zadaniye
maxD_not_div3(0,CurMax,Max):-Max is CurMax,!.
maxD_not_div3(X,CurMax,Max):- X1 is X div 10, M is X mod 10,
    (M>CurMax,M mod 3 =\= 0,maxD_not_div3(X1,M,Max);maxD_not_div3(X1,CurMax,Max)),!.
maxD_not_div3(X,Max):-maxD_not_div3(X,-1,Max).
