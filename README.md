1.1 Background
Kickboxing is an important traditional martial art. It has been taught since 1970s. And also
it has become a modern sport for today. Many adult and children not only in japan but also
in many countries participate in that type of martial art. However, studying alone without a
professional guider or trainer can led to severe muscle injuries, I’m not saying you can’t
study alone, but you must understand what you’re doing well to avoid severe muscle
injuries and it can lead to bad habits. Therefore, learning the proper body motion and
posture of this sport is important for your safety.
1.2 Motivation
In this project our main motivation is practicing at home at any time with less money
consumption, and of course money consumption is a headache for many people as
they pay lot of money on personal trainers. At an interview with a coach in “UFC”
gym “Ali el magrabi” he said “most students have only one instructor”, and that can
be a problem for most student when they learn hard moves.so, the tracking
technology can be useful for that problem. Because this system is similar on how a
trainer or coach tracks a participant when he or she does a movement. There are
some technical challenges the system will face such as, giving feedback for the user
in real time, capturing the 26 joins in the human body and saving it in the database
in real time. Comparing the two-time series with each other to get the right move.
This system is developed to make the martial art more favorable to practice without
leaving home, and without consuming a lot of money. Our goal is to create a software
that help the user to practice martial arts without the need for an instructor.
1.3 Problem Definitions
Many developers around was trying to develop a sport training system to help
individuals to have self-training for specific branch of sport that is depending on
human POS like (kick-boxing) those developments was dedicated to one sport at a
time separately there are no common system or single system platform that can
including all those sports at once, so the system will be generalized to any type of

human-poses martial art, but the many focus of the system in the first phase is kick-
boxing.

11

Project Description
Figure (2). Architectural Design.

2.1 Scope
My project will make the user insert new move using visual gesture builder(VGB),
which will be helpful for the user and the coach, by making the student study the
moves alone in home, and also give’s real-time feedback which will be helpful for
the student to now if his right or wrong. The program is mostly for learning
kickboxing via Kinect cam 2.0 or higher.

12

2.2 Project Overview
The system will work with Kinect cam 2.0, which it has its own Software
development kit (SDK) that can be used to develop the training set by recording the
clip using Kinect studio, after the clip is recorded we can take this clip, and start the
analysis phase which we will use the clip to make our own training set using visual

gesture build (VGB). In (VGB) the tool it works with an algorithm that is could ad-
booster which it can be used in classifying the correct move. After creating the

moves using (VGB), we can take the trained set, and put it in our system by just
taking the auto-created (.txt) that was created using (VGB), and put it in our system.
