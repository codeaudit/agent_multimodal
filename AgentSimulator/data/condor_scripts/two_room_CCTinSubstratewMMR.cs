requirements=InMastodon
+Group="GRAD"
+Project="AI_ROBOTICS"
+ProjectDescription="Multiagent HyperNEAT"
executable = /usr/bin/mono
Initialdir = /scratch/cluster/schrum2/HyperNEAT
Notification = always
Notify_user = schrum2@cs.utexas.edu
Error  = logs/two_room_CCTinSubstratewMMR.err.$(Process)
Output = logs/two_room_CCTinSubstratewMMR.out.$(Process)

arguments = ./AgentSimulator.exe evolve -experiment EXP_two_room-CCTinSubstratewMMR.xml -generations 2000 -rng_seed $(Process) -folder results/two-room-CCTinSubstratewMMR-$(Process)-
queue 10

