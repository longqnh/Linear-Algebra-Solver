restart;
packageDir:=cat(currentdir(),kernelopts(dirsep),"package.mla"):
march('open',packageDir):
with(DSTT):
X:=Matrix(5,5,[[24,10,18,30,39],[38,38,48,16,39],[4,25,17,32,39],[5,49,2,7,42],[16,46,43,20,15]]):
Y:=Matrix(5,1,[34,39,1,35,46]):
K:=Gauss(X,Y):
L:=StepSolve(K):
dir := FileTools:-JoinPath([convert(currentdir(),string),"output.txt"]):
if not FileTools:-Exists(dir) then Export(dir, ""): fi:
FileTools[Text]:-Open(dir, overwrite):
for i from 1 to nops(L) do FileTools[Text]:-WriteString(dir, op(i,L)); FileTools[Text]:-WriteString(dir, "\n"); od:
FileTools[Text]:-Close(dir);
