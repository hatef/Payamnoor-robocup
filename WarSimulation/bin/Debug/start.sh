#!/bin/bash
#Sample start script
AGENT_BINARY="Hadaf.exe"
for i in `seq 1 $1`
do
$AGENT_BINARY –h $2 >log/stdout.$i 2> log/stderr.$i
sleep 2
done;