package com.example.demo.entity;

import com.googlecode.objectify.annotation.Entity;
import com.googlecode.objectify.annotation.Index;

import javax.validation.constraints.Min;
import javax.validation.constraints.NotNull;

@Entity
public class Triangle {
    @NotNull
    @Index
    @Min(value = 0L, message = "The value must be positive")
    private double firstSide;
    @NotNull
    @Index
    @Min(value = 0L, message = "The value must be positive")
    private double secondSide;
    @NotNull
    @Index
    @Min(value = 0L, message = "The value must be positive")
    private double thirdSide;

    public Triangle() {
    }

    public Triangle(@NotNull @Min(value = 0L, message = "The value must be positive") double firstSide, @NotNull @Min(value = 0L, message = "The value must be positive") double secondSide, @NotNull @Min(value = 0L, message = "The value must be positive") double thirdSide) {
        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public double getFirstSide() {
        return firstSide;
    }

    public void setFirstSide(double firstSide) {
        this.firstSide = firstSide;
    }

    public double getSecondSide() {
        return secondSide;
    }

    public void setSecondSide(double secondSide) {
        this.secondSide = secondSide;
    }

    public double getThirdSide() {
        return thirdSide;
    }

    public void setThirdSide(double thirdSide) {
        this.thirdSide = thirdSide;
    }
}
