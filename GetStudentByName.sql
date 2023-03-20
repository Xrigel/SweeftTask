SELECT t.Teacher_ID,t.first_name, t.last_name,t.Sex,t.Subject
FROM Teacher t
INNER JOIN PupilAndTeacher pt ON pt.Teacher_ID=t.Teacher_ID
INNER JOIN Pupil p ON pt.Pupil_ID=p.Pupil_ID
WHERE p.first_name = N'გიორგი';
