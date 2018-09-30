package com.example.demo.entity;

import com.googlecode.objectify.annotation.Entity;
import com.googlecode.objectify.annotation.Id;
import com.googlecode.objectify.annotation.Index;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Size;
import java.util.Date;

@Entity
public class User {
    @Id
    private long id;
    @Index
    @NotNull
    @Size(min = 3, max = 14,message = "FirstName should have atleast 3 character and maximum 14 character")
    private String firstName;
    @Index
    @NotNull
    @Size(min = 3, max = 14,message = "LastName should have atleast 3 character and maximum 14 character")
    private String lastName;
    @Index
    @NotNull
    private Date birthDay;
    @Index
    private Member member;

    public User() {
    }

    public User(long id, @NotNull @Size(min = 3, max = 14, message = "FirstName should have atleast 3 character and maximum 14 character") String firstName, @NotNull @Size(min = 3, max = 14, message = "LastName should have atleast 3 character and maximum 14 character") String lastName, @NotNull Date birthDay, Member member) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDay = birthDay;
        this.member = member;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public Date getBirthDay() {
        return birthDay;
    }

    public void setBirthDay(Date birthDay) {
        this.birthDay = birthDay;
    }

    public Member getMember() {
        return member;
    }

    public void setMember(Member member) {
        this.member = member;
    }
}
